using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LiveSplit.CrashCounter
{
	public class Component : IComponent
	{
		[DllImport("kernel32")]
		private static extern bool GetExitCodeProcess(IntPtr handle, out int exitCode);

		private Settings settings;

		public string ComponentName => "Crash Counter";

		public float PaddingTop => 0;
		public float PaddingLeft => 0;
		public float PaddingBottom => 0;
		public float PaddingRight => 0;

		public float VerticalHeight => settings.GraphHeight;
		public float MinimumWidth => 180;
		public float HorizontalWidth => settings.GraphWidth;
		public float MinimumHeight => settings.GraphHeight;

		public IDictionary<string, Action> ContextMenuControls => null;
		bool firstLoad = true;

		private int graphHeight;
		private int graphWidth;

		private uint v_NumberOfCrashes = 0;
		private uint v_NumberOfCrashesTotal = 0;


		private bool overrideTextColorEnabled = false;

		private Color OverrideTextColor;

		private string processName = "";
		private Process process;
		private IntPtr processHandle = IntPtr.Zero;


		private Bitmap bmpBuffer;
		private Graphics gBuffer;

		private Brush BGBrush;
		private byte BGBrushOpacity;

		private StringFormat valueTextFormat;
		private StringFormat descriptiveTextFormat;
		LiveSplitState state;
		private string gameName;


		public Component(LiveSplitState state)
		{
			valueTextFormat = new StringFormat(StringFormatFlags.NoWrap)
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Far
			};

			descriptiveTextFormat = new StringFormat(StringFormatFlags.NoWrap)
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near
			};

			this.state = state;

			settings = new Settings();
			settings.UpdateGame(state.Run.GameName);
			state.RunManuallyModified += State_RunManuallyModified;
			settings.HandleDestroyed += SettingsUpdated;
			state.Form.FormClosing += TriggerSaveXML;
			gameName = state.Run.GameName;
			SettingsUpdated(null, null);
		}

		private void TriggerSaveXML(object sender, FormClosingEventArgs e)
		{
			//settings.crashBank.UpdateGameInfo(gameName, settings.ProcessName, v_NumberOfCrashesTotal, settings.AllowedReturnCodes);
		}

		private void SettingsUpdated(object sender, EventArgs e)
		{
			overrideTextColorEnabled = settings.FieldOverrideTextColor;

			OverrideTextColor = settings.OverrideTextColor;
			BGBrush = new SolidBrush(settings.BackgroundColor);
			BGBrushOpacity = settings.BackgroundColor.A;
			processName = settings.currentGameCrashes.ProcessName.ToLower();
			v_NumberOfCrashes = settings.NumberOfCrashesSession;
			v_NumberOfCrashesTotal = settings.currentGameCrashes.Crashes;


			if (graphHeight != settings.GraphHeight || graphWidth != settings.GraphWidth)
			{
				graphHeight = settings.GraphHeight;
				graphWidth = settings.GraphWidth;

				bmpBuffer = new Bitmap(graphWidth, graphHeight);
				gBuffer = Graphics.FromImage(bmpBuffer);
				gBuffer.Clear(Color.Transparent);
				gBuffer.CompositingMode = CompositingMode.SourceCopy;
			}
		}

		private static Color Blend(Color backColor, Color color, double amount)
		{
			byte a = (byte)((color.A * amount) + backColor.A * (1 - amount));
			byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
			byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
			byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
			return Color.FromArgb(a, r, g, b);
		}

		public void DrawGraph(Graphics g, LiveSplitState state, float width, float height)
		{
			if (firstLoad)
			{
				SettingsUpdated(null, null);
				firstLoad = false;
			}
			// figure out where to draw the graph
			RectangleF graphRect = new RectangleF
			{
				Y = 0,
				Width = width,
				Height = height,
				X = 0
			};

			// draw descriptive text
			Font font = state.LayoutSettings.TextFont;
			Brush fontBrush;
			if (!overrideTextColorEnabled)
				fontBrush = new SolidBrush(state.LayoutSettings.TextColor);
			else
				fontBrush = new SolidBrush(OverrideTextColor);
			Brush seperatorBrush = new SolidBrush(state.LayoutSettings.ThinSeparatorsColor);
			RectangleF rect = graphRect;
			if (BGBrushOpacity != 0)
				g.FillRectangle(BGBrush, rect);
			rect.X += 5;
			rect.Width -= 10;
			float x = rect.X;
			float y = 0;

			DrawElementInTracker(g, font, fontBrush, seperatorBrush, x, y, rect.Width, rect.Height);
		}

		private void DrawElementInTracker(Graphics g, Font font, Brush fontBrush, Brush seperatorBrush, float x, float y, float width, float height)
		{
			g.DrawString("Crashes: ", font, fontBrush, new RectangleF(x, y, width, height), descriptiveTextFormat);
			g.DrawString(v_NumberOfCrashes.ToString(), font, fontBrush, new RectangleF(x, y, width / 2 - 5, height), valueTextFormat);
			g.FillRectangle(seperatorBrush, width / 2 + 2, 0, 2, height);
			g.DrawString("Total: ", font, fontBrush, new RectangleF(width / 2 + 5, y, width, height), descriptiveTextFormat);
			g.DrawString(v_NumberOfCrashesTotal.ToString(), font, fontBrush, new RectangleF(x, y, width, height), valueTextFormat);
		}

		private void DrawBackground(Graphics g, LiveSplitState state, float width, float height)
		{
			if (settings.BackgroundColor.A == 0)
			{
				Brush gradientBrush = new SolidBrush(settings.BackgroundColor);
				g.FillRectangle(gradientBrush, 0, 0, width, height);
			}
		}

		public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
			DrawBackground(g, state, width, VerticalHeight);
			DrawGraph(g, state, width, VerticalHeight);
		}

		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
			DrawBackground(g, state, HorizontalWidth, height);
			DrawGraph(g, state, HorizontalWidth, height);
		}

		public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
		{
			if (process != null && !process.HasExited)
			{
				if (processHandle == IntPtr.Zero)
				{
					processHandle = process.Handle;
				}

				if (invalidator != null)
				{
					invalidator.Invalidate(0, 0, width, height);
				}
			}
			else if (process != null && process.HasExited)
			{
				GetExitCodeProcess(processHandle, out int exitCode);
				if (settings != null)
					settings.LastReturnCode = exitCode;
				if (settings.currentGameCrashes.AllowedReturnCodes.Length > 0 ? !settings.currentGameCrashes.AllowedReturnCodes.Contains(exitCode) : exitCode != 0)
				{
					v_NumberOfCrashes++;
					v_NumberOfCrashesTotal++;
					settings.PlaySound();
				}

				process = null;
				processHandle = IntPtr.Zero;
			}
			else
			{
				process = System.Diagnostics.Process.GetProcessesByName(processName).FirstOrDefault();
			}
		}

		public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
		{
			return settings;
		}

		public void SetSettings(System.Xml.XmlNode settings)
		{
			this.settings.SetSettings(settings);
		}

		public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
		{
			return settings.GetSettings(document);
		}

		public int GetSettingsHashCode()
		{
			return settings.GetSettingsHashCode();
		}

		protected virtual void Dispose(bool disposing)
		{
			state.RunManuallyModified -= State_RunManuallyModified;

			bmpBuffer.Dispose();
			valueTextFormat.Dispose();
			descriptiveTextFormat.Dispose();
			settings.Dispose();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void State_RunManuallyModified(object sender, EventArgs e)
		{
			settings.UpdateGame(state.Run.GameName);
		}
	}
}
