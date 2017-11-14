using LiveSplit.ComponentUtil;
using LiveSplit.UI;
using System;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

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
        public uint NumberOfCrashesTotal { get; set; }
        public string ProcessName { get; set; }

        public bool fieldOverrideTextColor { get; set; }

        public CrashStoring crashBank;
        #endregion


        public Settings()
        {
            crashBank = new CrashStoring();
            InitializeComponent();
            setStartValues();

            GraphWidth = 200;
            GraphHeight = 30;

            //Color Buttons
            btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOverrideTextColor.DataBindings.Add("BackColor", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            TB_CrasshesSession.DataBindings.Add("Text", this, "NumberOfCrashesSession", false, DataSourceUpdateMode.OnPropertyChanged);
            TB_CrasshesTotal.DataBindings.Add("Text", this, "NumberOfCrashesTotal", false, DataSourceUpdateMode.OnPropertyChanged);


            //Checkboxes
            CB_OverrideTextColorEnabled.DataBindings.Add("Checked", this, "fieldOverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void setStartValues()
        {
            GraphHeight = 0;
            fieldOverrideTextColor = false;
            NumberOfCrashesSession = 0;
            NumberOfCrashesTotal = 0;

            BackgroundColor = Color.Transparent;
            OverrideTextColor = Color.White;
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }        

        public void SetSettings(System.Xml.XmlNode node)
        {
            System.Xml.XmlElement element = (System.Xml.XmlElement) node;

            GraphWidth = SettingsHelper.ParseInt(element["GraphWidth"]);
            GraphHeight = SettingsHelper.ParseInt(element["GraphHeight"]);

            fieldOverrideTextColor = SettingsHelper.ParseBool(element["fieldOverrideTextColor"]);

            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);

            OverrideTextColor = SettingsHelper.ParseColor(element["OverrideTextColor"]);

            ProcessName = SettingsHelper.ParseString(element["ProcessName"]);
            TB_ProcessName.Text = ProcessName;
            NumberOfCrashesSession = 0;
            NumberOfCrashesTotal = crashBank.GetTotalCrashes(ProcessName);
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

            SettingsHelper.CreateSetting(document, parent, "fieldOverrideTextColor", fieldOverrideTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
            SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "ProcessName", ProcessName);
        }

        private void B_SetProcessName_Click(object sender, EventArgs e)
        {
            crashBank.UpdateGameInfo(ProcessName, NumberOfCrashesTotal);
            ProcessName = TB_ProcessName.Text.ToLower();
            TB_CrasshesSession.Text = 0.ToString();
            TB_CrasshesTotal.Text = crashBank.GetTotalCrashes(ProcessName).ToString();
        }

        private void B_SetCrashes_Click(object sender, EventArgs e)
        {
            uint temp;
            if(uint.TryParse(TB_CrasshesSession.Text, out temp))
                NumberOfCrashesTotal = temp;

            if(uint.TryParse(TB_CrasshesTotal.Text, out temp))
                NumberOfCrashesTotal = temp;

            crashBank.UpdateGameInfo(ProcessName, NumberOfCrashesTotal);
        }
    }
}
