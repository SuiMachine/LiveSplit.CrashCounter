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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.grpPointerPath.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpPointerPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpGraph, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpPointerPath
            // 
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
            this.grpPointerPath.Size = new System.Drawing.Size(455, 78);
            this.grpPointerPath.TabIndex = 0;
            this.grpPointerPath.TabStop = false;
            this.grpPointerPath.Text = "Settings:";
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
            this.grpGraph.Location = new System.Drawing.Point(3, 87);
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
            // Settings
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(461, 217);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpPointerPath.ResumeLayout(false);
            this.grpPointerPath.PerformLayout();
            this.grpGraph.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
    }
}
