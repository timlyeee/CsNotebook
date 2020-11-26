namespace DockPanelTest
{
    partial class NewDockContent
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
            this.SettingPanel = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.Customized = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalFontDialog = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.FontOfSetting = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CarColor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CarName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingPanel.SuspendLayout();
            this.General.SuspendLayout();
            this.Customized.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.General);
            this.SettingPanel.Controls.Add(this.Customized);
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.SelectedIndex = 0;
            this.SettingPanel.Size = new System.Drawing.Size(726, 333);
            this.SettingPanel.TabIndex = 0;
            this.SettingPanel.SelectedIndexChanged += new System.EventHandler(this.SettingPanel_SelectedIndexChanged);
            // 
            // General
            // 
            this.General.Controls.Add(this.UserName);
            this.General.Controls.Add(this.label4);
            this.General.Location = new System.Drawing.Point(4, 29);
            this.General.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.General.Size = new System.Drawing.Size(718, 300);
            this.General.TabIndex = 0;
            this.General.Text = "通用";
            this.General.UseVisualStyleBackColor = true;
            // 
            // Customized
            // 
            this.Customized.Controls.Add(this.CarName);
            this.Customized.Controls.Add(this.label3);
            this.Customized.Controls.Add(this.button3);
            this.Customized.Controls.Add(this.CarColor);
            this.Customized.Controls.Add(this.label2);
            this.Customized.Controls.Add(this.FontOfSetting);
            this.Customized.Controls.Add(this.button1);
            this.Customized.Controls.Add(this.label1);
            this.Customized.Location = new System.Drawing.Point(4, 29);
            this.Customized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customized.Name = "Customized";
            this.Customized.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customized.Size = new System.Drawing.Size(718, 300);
            this.Customized.TabIndex = 1;
            this.Customized.Text = "个性化设置";
            this.Customized.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "应用全局字体";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GlobalFontDialog
            // 
            this.GlobalFontDialog.Font = global::DockPanelTest.Properties.Settings.Default.Font;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontOfSetting
            // 
            this.FontOfSetting.Location = new System.Drawing.Point(32, 37);
            this.FontOfSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FontOfSetting.Name = "FontOfSetting";
            this.FontOfSetting.ReadOnly = true;
            this.FontOfSetting.Size = new System.Drawing.Size(201, 27);
            this.FontOfSetting.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "车辆颜色";
            // 
            // CarColor
            // 
            this.CarColor.Location = new System.Drawing.Point(32, 80);
            this.CarColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarColor.Name = "CarColor";
            this.CarColor.ReadOnly = true;
            this.CarColor.Size = new System.Drawing.Size(201, 27);
            this.CarColor.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "选择..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CarName
            // 
            this.CarName.Location = new System.Drawing.Point(32, 126);
            this.CarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(201, 27);
            this.CarName.TabIndex = 9;
            this.CarName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "车辆名称";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(625, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmBtn.Location = new System.Drawing.Point(528, 338);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(91, 30);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "确认";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // UserName
            // 
            this.UserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DockPanelTest.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UserName.Location = new System.Drawing.Point(32, 37);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(199, 27);
            this.UserName.TabIndex = 11;
            this.UserName.Text = global::DockPanelTest.Properties.Settings.Default.UserName;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "用户名称";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NewDockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 378);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SettingPanel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(744, 425);
            this.Name = "NewDockContent";
            this.Text = "设置";
            this.SettingPanel.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Customized.ResumeLayout(false);
            this.Customized.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingPanel;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Customized;
        private System.Windows.Forms.MaskedTextBox FontOfSetting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog GlobalFontDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CarColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox CarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}