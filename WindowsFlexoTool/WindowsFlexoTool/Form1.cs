using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFlexoTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zamknij_program(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void onLoad_program(object sender, EventArgs e)
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Windows Flexo Tool v" + version;
            toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
        }
    }
}
