﻿using LiveSplit.ComponentUtil;
using LiveSplit.UI;
using System;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using NAudio.Wave;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LiveSplit.CrashCounter
{
	partial class Settings : UserControl
	{
		#region Properties
		public Color BackgroundColor { get; set; }

		public Color OverrideTextColor { get; set; }

		public int GraphWidth { get; set; }
		public int GraphHeight { get; set; }
		public uint NumberOfCrashesSession { get; set; }

		public bool UseSound { get; set; }
		public float SoundVolume { get; set; }
		public string SoundFilePath { get; set; }
		public int LastReturnCode { get; set; }
		private WaveOut Player { get; set; }

		public bool FieldOverrideTextColor { get; set; }

		public CrashStoring crashBank;
		public CrashStoring.CrashCounterGame currentGameCrashes { get; set; }
		#endregion


		public Settings()
		{
			crashBank = CrashStoring.GetInstance();
			currentGameCrashes = new CrashStoring.CrashCounterGame();
			InitializeComponent();
			SetStartValues();
			Player = new WaveOut();

			GraphWidth = 200;
			GraphHeight = 30;

			//Color Buttons
			btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
			btnOverrideTextColor.DataBindings.Add("BackColor", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
			TB_CrasshesSession.DataBindings.Add("Text", this, "NumberOfCrashesSession", false, DataSourceUpdateMode.OnPropertyChanged);
			TB_SoundPath.DataBindings.Add("Text", this, "SoundFilePath", false, DataSourceUpdateMode.OnPropertyChanged);
			L_LastReturnCode.DataBindings.Add("Text", this, "LastReturnCode", false, DataSourceUpdateMode.OnPropertyChanged);

			//Checkboxes
			CB_OverrideTextColorEnabled.DataBindings.Add("Checked", this, "fieldOverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
			CB_PlaySoundOnCrash.DataBindings.Add("Checked", this, "UseSound", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void SetStartValues()
		{
			GraphHeight = 0;
			FieldOverrideTextColor = false;
			NumberOfCrashesSession = 0;
			LastReturnCode = 0;

			UseSound = false;
			SoundVolume = 0.5f;
			SoundFilePath = "";

			BackgroundColor = Color.Transparent;
			OverrideTextColor = Color.White;
		}

		private void ColorButtonClick(object sender, EventArgs e)
		{
			SettingsHelper.ColorButtonClick((Button)sender, this);
		}

		public void SetSettings(System.Xml.XmlNode node)
		{
			System.Xml.XmlElement element = (System.Xml.XmlElement)node;

			GraphWidth = SettingsHelper.ParseInt(element["GraphWidth"]);
			GraphHeight = SettingsHelper.ParseInt(element["GraphHeight"]);

			FieldOverrideTextColor = SettingsHelper.ParseBool(element["fieldOverrideTextColor"]);

			BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);

			OverrideTextColor = SettingsHelper.ParseColor(element["OverrideTextColor"]);

			UseSound = SettingsHelper.ParseBool(element["UseSound"]);
			SoundVolume = SettingsHelper.ParseFloat(element["SoundVolume"]);
			SoundFilePath = SettingsHelper.ParseString(element["SoundFilePath"]);

			TrackBar_SoundVolume.Value = (int)(SoundVolume * 100);
			L_SoundVolume.Text = string.Format("Volume: {0}%", TrackBar_SoundVolume.Value);
		}

		public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
		{
			System.Xml.XmlElement parent = document.CreateElement("Settings");
			CreateSettingsNode(document, parent);
			return parent;
		}

		public int GetSettingsHashCode()
		{
			return CreateSettingsNode(null, null);
		}

		private int CreateSettingsNode(System.Xml.XmlDocument document, System.Xml.XmlElement parent)
		{
			return SettingsHelper.CreateSetting(document, parent, "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) ^
			SettingsHelper.CreateSetting(document, parent, "GraphWidth", GraphWidth) ^
			SettingsHelper.CreateSetting(document, parent, "GraphHeight", GraphHeight) ^

			SettingsHelper.CreateSetting(document, parent, "fieldOverrideTextColor", FieldOverrideTextColor) ^
			SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
			SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor) ^
			SettingsHelper.CreateSetting(document, parent, "UseSound", UseSound) ^
			SettingsHelper.CreateSetting(document, parent, "SoundVolume", SoundVolume) ^
			SettingsHelper.CreateSetting(document, parent, "SoundFilePath", SoundFilePath);
		}

		private void TB_SoundPath_Browse_Click(object sender, EventArgs e)
		{
			OpenFileDialog fdg = new OpenFileDialog()
			{
				Multiselect = false,
				Filter = "Wave files (*.wav)|*.wav"
			};

			DialogResult res = fdg.ShowDialog();
			if (res == DialogResult.OK)
			{
				TB_SoundPath.Text = fdg.FileName;
			}
		}

		public void PlaySound()
		{
			if (UseSound && File.Exists(SoundFilePath))
			{
				Task.Factory.StartNew(() =>
				{
					try
					{
						AudioFileReader afr = new AudioFileReader(SoundFilePath)
						{
							Volume = SoundVolume
						};
						Player.Init(afr);
						Player.Play();

					}
					catch (Exception e)
					{
						Debug.WriteLine("[CRASH COUNTER] " + e);
					}
				});
			}
		}

		private void B_Test_Click(object sender, EventArgs e)
		{
			PlaySound();
		}

		private void TrackBar_SoundVolume_Scroll(object sender, EventArgs e)
		{
			SoundVolume = TrackBar_SoundVolume.Value / 100f;
			L_SoundVolume.Text = string.Format("Volume: {0}%", TrackBar_SoundVolume.Value);
		}

		public void UpdateGame(string gameName)
		{
			currentGameCrashes = crashBank.GetGame(gameName);

			TB_ProcessName.DataBindings.Clear();
			TB_CrasshesTotal.DataBindings.Clear();
			TB_AllowedReturnCodes.DataBindings.Clear();

			//Game related
			TB_ProcessName.DataBindings.Add("Text", currentGameCrashes, "ProcessName", false, DataSourceUpdateMode.OnPropertyChanged);
			TB_CrasshesTotal.DataBindings.Add("Text", currentGameCrashes, "Crashes");
			TB_AllowedReturnCodes.DataBindings.Add("Text", currentGameCrashes, "AllowedReturnCodesString");
		}

		private void B_SetProcessName_Click(object sender, EventArgs e)
		{
			crashBank.Save();
		}

		private void B_SetCrashes_Click(object sender, EventArgs e)
		{
			crashBank.Save();
		}

		private void B_SetAllowedReturnCodes_Click(object sender, EventArgs e)
		{
			crashBank.Save();
		}
	}
}
