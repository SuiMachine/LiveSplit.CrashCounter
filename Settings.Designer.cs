using LiveSplit.UI;
using System;
using System.ComponentModel;
using System.Linq;

namespace LiveSplit.CrashCounter
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpPointerPath = new System.Windows.Forms.GroupBox();
            this.L_LastReturnCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_SetAllowedReturnCodes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_AllowedReturnCodes = new System.Windows.Forms.TextBox();
            this.TB_CrasshesTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.B_SetProcessName = new System.Windows.Forms.Button();
            this.B_SetCrashes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CrasshesSession = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ProcessName = new System.Windows.Forms.TextBox();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOverrideTextColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_OverrideTextColorEnabled = new System.Windows.Forms.CheckBox();
            this.grpSound = new System.Windows.Forms.GroupBox();
            this.L_SoundVolume = new System.Windows.Forms.Label();
            this.B_Test = new System.Windows.Forms.Button();
            this.TrackBar_SoundVolume = new System.Windows.Forms.TrackBar();
            this.TB_SoundPath_Browse = new System.Windows.Forms.Button();
            this.TB_SoundPath = new System.Windows.Forms.TextBox();
            this.CB_PlaySoundOnCrash = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpPointerPath.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpPointerPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpGraph, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpSound, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpPointerPath
            // 
            this.grpPointerPath.Controls.Add(this.L_LastReturnCode);
            this.grpPointerPath.Controls.Add(this.label4);
            this.grpPointerPath.Controls.Add(this.B_SetAllowedReturnCodes);
            this.grpPointerPath.Controls.Add(this.label1);
            this.grpPointerPath.Controls.Add(this.TB_AllowedReturnCodes);
            this.grpPointerPath.Controls.Add(this.TB_CrasshesTotal);
            this.grpPointerPath.Controls.Add(this.label6);
            this.grpPointerPath.Controls.Add(this.B_SetProcessName);
            this.grpPointerPath.Controls.Add(this.B_SetCrashes);
            this.grpPointerPath.Controls.Add(this.label5);
            this.grpPointerPath.Controls.Add(this.TB_CrasshesSession);
            this.grpPointerPath.Controls.Add(this.label2);
            this.grpPointerPath.Controls.Add(this.TB_ProcessName);
            this.grpPointerPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPointerPath.Location = new System.Drawing.Point(3, 3);
            this.grpPointerPath.Name = "grpPointerPath";
            this.grpPointerPath.Size = new System.Drawing.Size(455, 120);
            this.grpPointerPath.TabIndex = 0;
            this.grpPointerPath.TabStop = false;
            this.grpPointerPath.Text = "Settings:";
            // 
            // L_LastReturnCode
            // 
            this.L_LastReturnCode.AutoSize = true;
            this.L_LastReturnCode.Location = new System.Drawing.Point(102, 99);
            this.L_LastReturnCode.Name = "L_LastReturnCode";
            this.L_LastReturnCode.Size = new System.Drawing.Size(14, 13);
            this.L_LastReturnCode.TabIndex = 12;
            this.L_LastReturnCode.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last return code:";
            // 
            // B_SetAllowedReturnCodes
            // 
            this.B_SetAllowedReturnCodes.Location = new System.Drawing.Point(373, 74);
            this.B_SetAllowedReturnCodes.Name = "B_SetAllowedReturnCodes";
            this.B_SetAllowedReturnCodes.Size = new System.Drawing.Size(75, 23);
            this.B_SetAllowedReturnCodes.TabIndex = 10;
            this.B_SetAllowedReturnCodes.Text = "Set";
            this.B_SetAllowedReturnCodes.UseVisualStyleBackColor = true;
            this.B_SetAllowedReturnCodes.Click += new System.EventHandler(this.B_SetAllowedReturnCodes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Allowed return codes:";
            // 
            // TB_AllowedReturnCodes
            // 
            this.TB_AllowedReturnCodes.Location = new System.Drawing.Point(124, 76);
            this.TB_AllowedReturnCodes.Name = "TB_AllowedReturnCodes";
            this.TB_AllowedReturnCodes.Size = new System.Drawing.Size(243, 20);
            this.TB_AllowedReturnCodes.TabIndex = 8;
            // 
            // TB_CrasshesTotal
            // 
            this.TB_CrasshesTotal.Location = new System.Drawing.Point(267, 47);
            this.TB_CrasshesTotal.Name = "TB_CrasshesTotal";
            this.TB_CrasshesTotal.Size = new System.Drawing.Size(100, 20);
            this.TB_CrasshesTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Crashes Total:";
            // 
            // B_SetProcessName
            // 
            this.B_SetProcessName.Location = new System.Drawing.Point(373, 16);
            this.B_SetProcessName.Name = "B_SetProcessName";
            this.B_SetProcessName.Size = new System.Drawing.Size(75, 23);
            this.B_SetProcessName.TabIndex = 5;
            this.B_SetProcessName.Text = "Set";
            this.B_SetProcessName.UseVisualStyleBackColor = true;
            this.B_SetProcessName.Click += new System.EventHandler(this.B_SetProcessName_Click);
            // 
            // B_SetCrashes
            // 
            this.B_SetCrashes.Location = new System.Drawing.Point(373, 45);
            this.B_SetCrashes.Name = "B_SetCrashes";
            this.B_SetCrashes.Size = new System.Drawing.Size(75, 23);
            this.B_SetCrashes.TabIndex = 4;
            this.B_SetCrashes.Text = "Set";
            this.B_SetCrashes.UseVisualStyleBackColor = true;
            this.B_SetCrashes.Click += new System.EventHandler(this.B_SetCrashes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Crashes in session:";
            // 
            // TB_CrasshesSession
            // 
            this.TB_CrasshesSession.Location = new System.Drawing.Point(112, 47);
            this.TB_CrasshesSession.Name = "TB_CrasshesSession";
            this.TB_CrasshesSession.Size = new System.Drawing.Size(68, 20);
            this.TB_CrasshesSession.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Process name:";
            // 
            // TB_ProcessName
            // 
            this.TB_ProcessName.Location = new System.Drawing.Point(92, 18);
            this.TB_ProcessName.Name = "TB_ProcessName";
            this.TB_ProcessName.Size = new System.Drawing.Size(275, 20);
            this.TB_ProcessName.TabIndex = 0;
            // 
            // grpGraph
            // 
            this.grpGraph.Controls.Add(this.tableLayoutPanel3);
            this.grpGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGraph.Location = new System.Drawing.Point(3, 255);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(455, 114);
            this.grpGraph.TabIndex = 1;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 95);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Controls.Add(this.btnOverrideTextColor, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBackgroundColor1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CB_OverrideTextColorEnabled, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(443, 85);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnOverrideTextColor
            // 
            this.btnOverrideTextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOverrideTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverrideTextColor.Location = new System.Drawing.Point(413, 3);
            this.btnOverrideTextColor.Name = "btnOverrideTextColor";
            this.btnOverrideTextColor.Size = new System.Drawing.Size(29, 22);
            this.btnOverrideTextColor.TabIndex = 13;
            this.btnOverrideTextColor.UseVisualStyleBackColor = false;
            this.btnOverrideTextColor.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(135, 3);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(28, 22);
            this.btnBackgroundColor1.TabIndex = 6;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Background Color:";
            // 
            // CB_OverrideTextColorEnabled
            // 
            this.CB_OverrideTextColorEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_OverrideTextColorEnabled.AutoSize = true;
            this.CB_OverrideTextColorEnabled.Location = new System.Drawing.Point(219, 5);
            this.CB_OverrideTextColorEnabled.Name = "CB_OverrideTextColorEnabled";
            this.CB_OverrideTextColorEnabled.Size = new System.Drawing.Size(117, 17);
            this.CB_OverrideTextColorEnabled.TabIndex = 10;
            this.CB_OverrideTextColorEnabled.Text = "Override Text Color";
            this.CB_OverrideTextColorEnabled.UseVisualStyleBackColor = true;
            // 
            // grpSound
            // 
            this.grpSound.Controls.Add(this.L_SoundVolume);
            this.grpSound.Controls.Add(this.B_Test);
            this.grpSound.Controls.Add(this.TrackBar_SoundVolume);
            this.grpSound.Controls.Add(this.TB_SoundPath_Browse);
            this.grpSound.Controls.Add(this.TB_SoundPath);
            this.grpSound.Controls.Add(this.CB_PlaySoundOnCrash);
            this.grpSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSound.Location = new System.Drawing.Point(3, 129);
            this.grpSound.Name = "grpSound";
            this.grpSound.Size = new System.Drawing.Size(455, 120);
            this.grpSound.TabIndex = 2;
            this.grpSound.TabStop = false;
            this.grpSound.Text = "Sound";
            // 
            // L_SoundVolume
            // 
            this.L_SoundVolume.Location = new System.Drawing.Point(6, 100);
            this.L_SoundVolume.Name = "L_SoundVolume";
            this.L_SoundVolume.Size = new System.Drawing.Size(361, 23);
            this.L_SoundVolume.TabIndex = 5;
            this.L_SoundVolume.Text = "Volume: 0%";
            this.L_SoundVolume.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // B_Test
            // 
            this.B_Test.Location = new System.Drawing.Point(373, 71);
            this.B_Test.Name = "B_Test";
            this.B_Test.Size = new System.Drawing.Size(75, 23);
            this.B_Test.TabIndex = 4;
            this.B_Test.Text = "Test";
            this.B_Test.UseVisualStyleBackColor = true;
            this.B_Test.Click += new System.EventHandler(this.B_Test_Click);
            // 
            // TrackBar_SoundVolume
            // 
            this.TrackBar_SoundVolume.Location = new System.Drawing.Point(6, 68);
            this.TrackBar_SoundVolume.Maximum = 100;
            this.TrackBar_SoundVolume.Name = "TrackBar_SoundVolume";
            this.TrackBar_SoundVolume.Size = new System.Drawing.Size(361, 45);
            this.TrackBar_SoundVolume.TabIndex = 3;
            this.TrackBar_SoundVolume.Scroll += new System.EventHandler(this.TrackBar_SoundVolume_Scroll);
            // 
            // TB_SoundPath_Browse
            // 
            this.TB_SoundPath_Browse.Location = new System.Drawing.Point(373, 42);
            this.TB_SoundPath_Browse.Name = "TB_SoundPath_Browse";
            this.TB_SoundPath_Browse.Size = new System.Drawing.Size(75, 23);
            this.TB_SoundPath_Browse.TabIndex = 2;
            this.TB_SoundPath_Browse.Text = "Browse";
            this.TB_SoundPath_Browse.UseVisualStyleBackColor = true;
            this.TB_SoundPath_Browse.Click += new System.EventHandler(this.TB_SoundPath_Browse_Click);
            // 
            // TB_SoundPath
            // 
            this.TB_SoundPath.Location = new System.Drawing.Point(6, 42);
            this.TB_SoundPath.Name = "TB_SoundPath";
            this.TB_SoundPath.Size = new System.Drawing.Size(361, 20);
            this.TB_SoundPath.TabIndex = 1;
            // 
            // CB_PlaySoundOnCrash
            // 
            this.CB_PlaySoundOnCrash.AutoSize = true;
            this.CB_PlaySoundOnCrash.Location = new System.Drawing.Point(12, 19);
            this.CB_PlaySoundOnCrash.Name = "CB_PlaySoundOnCrash";
            this.CB_PlaySoundOnCrash.Size = new System.Drawing.Size(122, 17);
            this.CB_PlaySoundOnCrash.TabIndex = 0;
            this.CB_PlaySoundOnCrash.Text = "Play sound on crash";
            this.CB_PlaySoundOnCrash.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(461, 379);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpPointerPath.ResumeLayout(false);
            this.grpPointerPath.PerformLayout();
            this.grpGraph.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpSound.ResumeLayout(false);
            this.grpSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_SoundVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpPointerPath;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_OverrideTextColorEnabled;
        private System.Windows.Forms.Button btnOverrideTextColor;
        private System.Windows.Forms.TextBox TB_CrasshesTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_SetProcessName;
        private System.Windows.Forms.Button B_SetCrashes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CrasshesSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_ProcessName;
        private System.Windows.Forms.GroupBox grpSound;
        private System.Windows.Forms.Button TB_SoundPath_Browse;
        private System.Windows.Forms.TextBox TB_SoundPath;
        private System.Windows.Forms.CheckBox CB_PlaySoundOnCrash;
        private System.Windows.Forms.Button B_Test;
        private System.Windows.Forms.TrackBar TrackBar_SoundVolume;
        private System.Windows.Forms.Label L_SoundVolume;
        private System.Windows.Forms.Label L_LastReturnCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_SetAllowedReturnCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_AllowedReturnCodes;
    }
}
