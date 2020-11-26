using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockPanelTest
{
    public partial class NewDockContent : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public NewDockContent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GlobalFontDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Load setting from the default setting file. And show information to the current tabpage
        private void LoadSettings() {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void SettingPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Further for Using Switch code to load the data just in time
            if (SettingPanel.SelectedIndex == 1) {
                FontOfSetting.Text = Properties.Settings.Default.Font.ToString();
                CarColor.Text = Customised.Default.CarColor.ToString();
            }
        }
    }
}
