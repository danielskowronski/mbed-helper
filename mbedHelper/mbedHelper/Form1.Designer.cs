namespace mbedHelper
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_flashing = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_refreshDevices = new System.Windows.Forms.Button();
            this.comboBox_targetDevice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_selectBinFile = new System.Windows.Forms.Button();
            this.textBox_binFileName = new System.Windows.Forms.TextBox();
            this.button_flash = new System.Windows.Forms.Button();
            this.progressBar_flashing = new System.Windows.Forms.ProgressBar();
            this.tabPage_configuration = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_config_baudrate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_config_com = new System.Windows.Forms.TextBox();
            this.checkBox_config_putty = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_configDefaultDevice_targetPath = new System.Windows.Forms.TextBox();
            this.textBox_configDefaultDevice_targetName = new System.Windows.Forms.TextBox();
            this.radioButton_configDefaultDevice_byPath = new System.Windows.Forms.RadioButton();
            this.radioButton_configDefaultDevice_byName = new System.Windows.Forms.RadioButton();
            this.tabPage_about = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_homepage = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_howto = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog_binFile = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_restartPutty = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_flashing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_configuration.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_howto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_flashing);
            this.tabControl1.Controls.Add(this.tabPage_configuration);
            this.tabControl1.Controls.Add(this.tabPage_about);
            this.tabControl1.Controls.Add(this.tabPage_howto);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 152);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_flashing
            // 
            this.tabPage_flashing.Controls.Add(this.button_restartPutty);
            this.tabPage_flashing.Controls.Add(this.groupBox2);
            this.tabPage_flashing.Controls.Add(this.groupBox1);
            this.tabPage_flashing.Controls.Add(this.button_flash);
            this.tabPage_flashing.Controls.Add(this.progressBar_flashing);
            this.tabPage_flashing.Location = new System.Drawing.Point(4, 22);
            this.tabPage_flashing.Name = "tabPage_flashing";
            this.tabPage_flashing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_flashing.Size = new System.Drawing.Size(476, 126);
            this.tabPage_flashing.TabIndex = 0;
            this.tabPage_flashing.Text = "flashing";
            this.tabPage_flashing.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_refreshDevices);
            this.groupBox2.Controls.Add(this.comboBox_targetDevice);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(289, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "select target device";
            // 
            // button_refreshDevices
            // 
            this.button_refreshDevices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_refreshDevices.Location = new System.Drawing.Point(146, 16);
            this.button_refreshDevices.Name = "button_refreshDevices";
            this.button_refreshDevices.Size = new System.Drawing.Size(27, 23);
            this.button_refreshDevices.TabIndex = 4;
            this.button_refreshDevices.Text = "F5";
            this.button_refreshDevices.UseVisualStyleBackColor = true;
            this.button_refreshDevices.Click += new System.EventHandler(this.button_refreshDevices_Click);
            // 
            // comboBox_targetDevice
            // 
            this.comboBox_targetDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_targetDevice.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_targetDevice.FormattingEnabled = true;
            this.comboBox_targetDevice.Location = new System.Drawing.Point(3, 16);
            this.comboBox_targetDevice.Name = "comboBox_targetDevice";
            this.comboBox_targetDevice.Size = new System.Drawing.Size(137, 21);
            this.comboBox_targetDevice.TabIndex = 3;
            this.comboBox_targetDevice.SelectedIndexChanged += new System.EventHandler(this.comboBox_targetDevice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_selectBinFile);
            this.groupBox1.Controls.Add(this.textBox_binFileName);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "select .bin file";
            // 
            // button_selectBinFile
            // 
            this.button_selectBinFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_selectBinFile.Location = new System.Drawing.Point(208, 16);
            this.button_selectBinFile.Name = "button_selectBinFile";
            this.button_selectBinFile.Size = new System.Drawing.Size(61, 23);
            this.button_selectBinFile.TabIndex = 5;
            this.button_selectBinFile.Text = "Select";
            this.button_selectBinFile.UseVisualStyleBackColor = true;
            this.button_selectBinFile.Click += new System.EventHandler(this.button_selectBinFile_Click);
            // 
            // textBox_binFileName
            // 
            this.textBox_binFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_binFileName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_binFileName.Location = new System.Drawing.Point(3, 16);
            this.textBox_binFileName.Name = "textBox_binFileName";
            this.textBox_binFileName.Size = new System.Drawing.Size(199, 20);
            this.textBox_binFileName.TabIndex = 1;
            // 
            // button_flash
            // 
            this.button_flash.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_flash.Location = new System.Drawing.Point(8, 60);
            this.button_flash.Name = "button_flash";
            this.button_flash.Size = new System.Drawing.Size(384, 34);
            this.button_flash.TabIndex = 2;
            this.button_flash.Text = "flash!";
            this.button_flash.UseVisualStyleBackColor = true;
            this.button_flash.Click += new System.EventHandler(this.button_flash_Click);
            // 
            // progressBar_flashing
            // 
            this.progressBar_flashing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_flashing.Location = new System.Drawing.Point(3, 100);
            this.progressBar_flashing.Name = "progressBar_flashing";
            this.progressBar_flashing.Size = new System.Drawing.Size(470, 23);
            this.progressBar_flashing.TabIndex = 0;
            // 
            // tabPage_configuration
            // 
            this.tabPage_configuration.Controls.Add(this.groupBox4);
            this.tabPage_configuration.Controls.Add(this.groupBox3);
            this.tabPage_configuration.Location = new System.Drawing.Point(4, 22);
            this.tabPage_configuration.Name = "tabPage_configuration";
            this.tabPage_configuration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_configuration.Size = new System.Drawing.Size(476, 126);
            this.tabPage_configuration.TabIndex = 1;
            this.tabPage_configuration.Text = "configuration";
            this.tabPage_configuration.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox_config_baudrate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_config_com);
            this.groupBox4.Controls.Add(this.checkBox_config_putty);
            this.groupBox4.Location = new System.Drawing.Point(290, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 102);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PuTTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "BAUDrate";
            // 
            // textBox_config_baudrate
            // 
            this.textBox_config_baudrate.Location = new System.Drawing.Point(67, 71);
            this.textBox_config_baudrate.Name = "textBox_config_baudrate";
            this.textBox_config_baudrate.Size = new System.Drawing.Size(104, 20);
            this.textBox_config_baudrate.TabIndex = 3;
            this.textBox_config_baudrate.TextChanged += new System.EventHandler(this.textBox_config_baudrate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COM port";
            // 
            // textBox_config_com
            // 
            this.textBox_config_com.Location = new System.Drawing.Point(67, 45);
            this.textBox_config_com.Name = "textBox_config_com";
            this.textBox_config_com.Size = new System.Drawing.Size(104, 20);
            this.textBox_config_com.TabIndex = 1;
            this.textBox_config_com.TextChanged += new System.EventHandler(this.textBox_config_com_TextChanged);
            // 
            // checkBox_config_putty
            // 
            this.checkBox_config_putty.AutoSize = true;
            this.checkBox_config_putty.Location = new System.Drawing.Point(6, 19);
            this.checkBox_config_putty.Name = "checkBox_config_putty";
            this.checkBox_config_putty.Size = new System.Drawing.Size(80, 17);
            this.checkBox_config_putty.TabIndex = 0;
            this.checkBox_config_putty.Text = "use PuTTY";
            this.checkBox_config_putty.UseVisualStyleBackColor = true;
            this.checkBox_config_putty.CheckedChanged += new System.EventHandler(this.checkBox_config_putty_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_configDefaultDevice_targetPath);
            this.groupBox3.Controls.Add(this.textBox_configDefaultDevice_targetName);
            this.groupBox3.Controls.Add(this.radioButton_configDefaultDevice_byPath);
            this.groupBox3.Controls.Add(this.radioButton_configDefaultDevice_byName);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 76);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "default device";
            // 
            // textBox_configDefaultDevice_targetPath
            // 
            this.textBox_configDefaultDevice_targetPath.Location = new System.Drawing.Point(79, 45);
            this.textBox_configDefaultDevice_targetPath.Name = "textBox_configDefaultDevice_targetPath";
            this.textBox_configDefaultDevice_targetPath.Size = new System.Drawing.Size(100, 20);
            this.textBox_configDefaultDevice_targetPath.TabIndex = 3;
            this.textBox_configDefaultDevice_targetPath.TextChanged += new System.EventHandler(this.textBox_configDefaultDevice_targetPath_TextChanged);
            // 
            // textBox_configDefaultDevice_targetName
            // 
            this.textBox_configDefaultDevice_targetName.Location = new System.Drawing.Point(79, 19);
            this.textBox_configDefaultDevice_targetName.Name = "textBox_configDefaultDevice_targetName";
            this.textBox_configDefaultDevice_targetName.Size = new System.Drawing.Size(100, 20);
            this.textBox_configDefaultDevice_targetName.TabIndex = 2;
            this.textBox_configDefaultDevice_targetName.TextChanged += new System.EventHandler(this.textBox_configDefaultDevice_targetName_TextChanged);
            // 
            // radioButton_configDefaultDevice_byPath
            // 
            this.radioButton_configDefaultDevice_byPath.AutoSize = true;
            this.radioButton_configDefaultDevice_byPath.Location = new System.Drawing.Point(6, 48);
            this.radioButton_configDefaultDevice_byPath.Name = "radioButton_configDefaultDevice_byPath";
            this.radioButton_configDefaultDevice_byPath.Size = new System.Drawing.Size(67, 17);
            this.radioButton_configDefaultDevice_byPath.TabIndex = 1;
            this.radioButton_configDefaultDevice_byPath.TabStop = true;
            this.radioButton_configDefaultDevice_byPath.Text = "by path";
            this.radioButton_configDefaultDevice_byPath.UseVisualStyleBackColor = true;
            this.radioButton_configDefaultDevice_byPath.CheckedChanged += new System.EventHandler(this.radioButton_configDefaultDevice_byPath_CheckedChanged);
            // 
            // radioButton_configDefaultDevice_byName
            // 
            this.radioButton_configDefaultDevice_byName.AutoSize = true;
            this.radioButton_configDefaultDevice_byName.Location = new System.Drawing.Point(6, 19);
            this.radioButton_configDefaultDevice_byName.Name = "radioButton_configDefaultDevice_byName";
            this.radioButton_configDefaultDevice_byName.Size = new System.Drawing.Size(67, 17);
            this.radioButton_configDefaultDevice_byName.TabIndex = 0;
            this.radioButton_configDefaultDevice_byName.TabStop = true;
            this.radioButton_configDefaultDevice_byName.Text = "by name";
            this.radioButton_configDefaultDevice_byName.UseVisualStyleBackColor = true;
            this.radioButton_configDefaultDevice_byName.CheckedChanged += new System.EventHandler(this.radioButton_configDefaultDevice_byName_CheckedChanged);
            // 
            // tabPage_about
            // 
            this.tabPage_about.Controls.Add(this.linkLabel1);
            this.tabPage_about.Controls.Add(this.linkLabel_homepage);
            this.tabPage_about.Controls.Add(this.label2);
            this.tabPage_about.Controls.Add(this.label1);
            this.tabPage_about.Controls.Add(this.pictureBox1);
            this.tabPage_about.Location = new System.Drawing.Point(4, 22);
            this.tabPage_about.Name = "tabPage_about";
            this.tabPage_about.Size = new System.Drawing.Size(476, 126);
            this.tabPage_about.TabIndex = 2;
            this.tabPage_about.Text = "about";
            this.tabPage_about.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(132, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(234, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://developer.mbed.org";
            // 
            // linkLabel_homepage
            // 
            this.linkLabel_homepage.AutoSize = true;
            this.linkLabel_homepage.Font = new System.Drawing.Font("Consolas", 12F);
            this.linkLabel_homepage.Location = new System.Drawing.Point(132, 53);
            this.linkLabel_homepage.Name = "linkLabel_homepage";
            this.linkLabel_homepage.Size = new System.Drawing.Size(333, 38);
            this.linkLabel_homepage.TabIndex = 4;
            this.linkLabel_homepage.TabStop = true;
            this.linkLabel_homepage.Text = "software homepage: \r\nhttp://software.dsinf.net/mbedHelper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(130, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "author: Daniel \"assembler\" Skowroński";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "mbed.org helper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage_howto
            // 
            this.tabPage_howto.Controls.Add(this.richTextBox1);
            this.tabPage_howto.Location = new System.Drawing.Point(4, 22);
            this.tabPage_howto.Name = "tabPage_howto";
            this.tabPage_howto.Size = new System.Drawing.Size(476, 126);
            this.tabPage_howto.TabIndex = 3;
            this.tabPage_howto.Text = "how-to";
            this.tabPage_howto.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 126);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // openFileDialog_binFile
            // 
            this.openFileDialog_binFile.DefaultExt = "bin";
            this.openFileDialog_binFile.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_restartPutty
            // 
            this.button_restartPutty.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_restartPutty.Location = new System.Drawing.Point(398, 60);
            this.button_restartPutty.Name = "button_restartPutty";
            this.button_restartPutty.Size = new System.Drawing.Size(70, 34);
            this.button_restartPutty.TabIndex = 6;
            this.button_restartPutty.Text = "restart PuTTY";
            this.button_restartPutty.UseVisualStyleBackColor = true;
            this.button_restartPutty.Click += new System.EventHandler(this.button_restartPutty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 152);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "mbed.org helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_flashing.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_configuration.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage_about.ResumeLayout(false);
            this.tabPage_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_howto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_flashing;
        private System.Windows.Forms.ProgressBar progressBar_flashing;
        private System.Windows.Forms.TabPage tabPage_configuration;
        private System.Windows.Forms.TabPage tabPage_about;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel_homepage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_flash;
        private System.Windows.Forms.TextBox textBox_binFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog_binFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_targetDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_refreshDevices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_configDefaultDevice_byPath;
        private System.Windows.Forms.RadioButton radioButton_configDefaultDevice_byName;
        private System.Windows.Forms.TextBox textBox_configDefaultDevice_targetPath;
        private System.Windows.Forms.TextBox textBox_configDefaultDevice_targetName;
        private System.Windows.Forms.Button button_selectBinFile;
        private System.Windows.Forms.TabPage tabPage_howto;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_config_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_config_com;
        private System.Windows.Forms.CheckBox checkBox_config_putty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_restartPutty;
    }
}

