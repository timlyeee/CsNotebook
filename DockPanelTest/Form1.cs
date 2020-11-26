using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace DockPanelTest
{
    public partial class Form1 : Form
    {
        private DockPanel dockPanel;

        public Form1()
        {

            InitializeComponent();

            
            ShowDockContent();
        }

        public void ShowDockContent()
        {
            var dock1 = new NewDockContent() { TabText = "Document" };
            dock1.Show(this.dockPanel1, DockState.Document);

            dock1 = new NewDockContent() { TabText = "DockLeft" };
            dock1.Show(this.dockPanel1, DockState.DockLeft);

            dock1 = new NewDockContent() { TabText = "DockRight" };
            dock1.Show(this.dockPanel1, DockState.DockRight);

            dock1 = new NewDockContent() { TabText = "DockTop" };
            dock1.Show(this.dockPanel1, DockState.DockTop);

        }
    }
}
