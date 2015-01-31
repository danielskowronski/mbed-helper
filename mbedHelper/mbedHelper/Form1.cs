using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace mbedHelper
{
    public partial class Form1 : Form
    {
        string[] _args; //stores args[] from application context
        Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager prog; //progress bar

        public Form1(string[] args)
        {
            _args = args; //command line args
            InitializeComponent();
        }

        string _selectedTargetPath = null; 

        private void refreshDevicesList()
        {
            comboBox_targetDevice.Items.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    comboBox_targetDevice.Items.Add(drive.RootDirectory + " - " + drive.VolumeLabel);
                }
            }
        }

        private void closeApp()
        {
            this.Close();
            Application.Exit();
        }
        private void loadSettings()
        {
            if (Properties.Settings.Default.defaultTargetType == "name")
            {
                radioButton_configDefaultDevice_byName.Checked = true;
                textBox_configDefaultDevice_targetName.Text = Properties.Settings.Default.defaultTargetValue;
            }
            else if (Properties.Settings.Default.defaultTargetType == "path")
            {
                radioButton_configDefaultDevice_byPath.Checked = false;
                textBox_configDefaultDevice_targetPath.Text = Properties.Settings.Default.defaultTargetValue;
            }

            #region detection_from_flashing_method <= FIXME
            if (Properties.Settings.Default.defaultTargetType == "name")
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && drive.VolumeLabel.IndexOf(Properties.Settings.Default.defaultTargetValue) != -1)
                    {
                        _selectedTargetPath = drive.RootDirectory.ToString();
                    }
                }
            }
            else if (Properties.Settings.Default.defaultTargetType == "path")
            {
                _selectedTargetPath = textBox_configDefaultDevice_targetPath.Text;
            }
            #endregion

            int idx = -1;
            for (int i = 0; i < comboBox_targetDevice.Items.Count; i++)
            {
                var a = comboBox_targetDevice.Items[i].ToString();
                if (_selectedTargetPath == null) break; //??
                if (a.IndexOf(_selectedTargetPath) != -1) { idx = i; break; }
            }
            if (idx >= 0)
                comboBox_targetDevice.SelectedIndex = idx;
            else
                _selectedTargetPath = null; //notify that there is error //FIXME

            checkBox_config_putty.Checked = Properties.Settings.Default.puttyEnabled;
            textBox_config_com.Text = Properties.Settings.Default.puttyCom;
            textBox_config_baudrate.Text = Properties.Settings.Default.puttyBaud.ToString();
        }
        private void setProgress(int current, Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState state = Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Normal, int max = 100)
        {
            progressBar_flashing.Maximum = max; progressBar_flashing.Value = current; //progressBar_flashing.ForeColor //TODO
            prog.SetProgressState(state);  prog.SetProgressValue(current, max);
        }
        private void flashFile(bool autoRun=true)
        {
            if (checkBox_config_putty.Checked)
            {
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("mbed_putty")) //note: there is no ".exe" part
                {
                    process.Kill();
                }
            }
            if (autoRun)
            {
                //return;
                this.WindowState = FormWindowState.Minimized; //to show progress on taskbar and don't bother user (note: developed on win 10 build 9926)
            }
            setProgress(0);

            string fileName = textBox_binFileName.Text;
            

            if (_selectedTargetPath == null || _selectedTargetPath=="")
            {
                MessageBox.Show("Target device not present - plug in device or change settings");
                return;
            }
            try
            {
                string t = _selectedTargetPath + "\\" + fileName.Substring(fileName.LastIndexOf("\\") + 1);

                setProgress(40, Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Indeterminate); 
                //TODO: smarter progress bar - maybe there is no other option but use dirty manual file copying

                if (System.IO.File.Exists(t)) {
                    setProgress(10, Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Paused);
                    System.IO.File.Delete(t);
                    setProgress(40, Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Indeterminate);
                }
                System.IO.File.Copy(fileName, t);
                setProgress(100);
            }
            catch (Exception ex)
            {
                setProgress(40, Microsoft.WindowsAPICodePack.Taskbar.TaskbarProgressBarState.Error);
                MessageBox.Show("Flash failed!\n\n" + ex.ToString());
                return;
            }
            if (checkBox_config_putty.Checked)
            {
                string b = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")+1);//app base path
                System.Diagnostics.Process.Start(b+ "mbed_putty.exe", "-serial " + textBox_config_com.Text + " " + textBox_config_baudrate.Text); 
            }
            if (autoRun)
            {
                timer1.Interval = 500;
                //timer1.Start();//sleep, then exit app //CP: for dev disable
            }
        }
        private void button_refreshDevices_Click(object sender, EventArgs e)
        {
            refreshDevicesList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshDevicesList();
            loadSettings();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            //note: this code need to be run on form shown becouse otherwise window handler for system progress bar wouldn't be available
            prog = Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.Instance;
            if (_args.Count() > 0)
            {
                textBox_binFileName.Text = _args[0];
                flashFile();
            }
        }

        private void button_selectBinFile_Click(object sender, EventArgs e)
        {
            string filename="";
            DialogResult result = openFileDialog_binFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = openFileDialog_binFile.FileName;
            }
            textBox_binFileName.Text = filename;
        }

        private void checkBox_config_putty_CheckedChanged(object sender, EventArgs e)
        {
           Properties.Settings.Default.puttyEnabled =  checkBox_config_putty.Checked;
           Properties.Settings.Default.Save();
        }

        private void textBox_config_com_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.puttyCom = textBox_config_com.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox_config_baudrate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.puttyBaud = Int32.Parse(textBox_config_baudrate.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baudrate should be number!");
                //textBox_config_baudrate.Text = "";
            }
        }

        private void radioButton_configDefaultDevice_byName_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = radioButton_configDefaultDevice_byName.Checked;
            if (isEnabled)
            {
                Properties.Settings.Default.defaultTargetType = "name";
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton_configDefaultDevice_byPath_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = radioButton_configDefaultDevice_byPath.Checked;
            if (isEnabled)
            {
                Properties.Settings.Default.defaultTargetType = "path";
                Properties.Settings.Default.Save();
            }
        }

        private void textBox_configDefaultDevice_targetName_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.defaultTargetType == "name")
            {
                Properties.Settings.Default.defaultTargetValue = textBox_configDefaultDevice_targetName.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void textBox_configDefaultDevice_targetPath_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.defaultTargetType == "path")
            {
                Properties.Settings.Default.defaultTargetValue = textBox_configDefaultDevice_targetPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void comboBox_targetDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IMPLEMENT ME, SENPAI!
        }

        private void button_flash_Click(object sender, EventArgs e)
        {
            flashFile(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            closeApp();
        }

        private void button_restartPutty_Click(object sender, EventArgs e)
        {
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("mbed_putty"))
            {
                process.Kill();
            }
            string b = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")+1);
            System.Diagnostics.Process.Start(b+"mbed_putty.exe", "-serial " + textBox_config_com.Text + " " + textBox_config_baudrate.Text);
        }
 
    }
}
