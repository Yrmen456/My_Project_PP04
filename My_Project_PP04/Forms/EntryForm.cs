using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP04.Control;
using My_Project_PP04.Control.Authorization;
using My_Project_PP04.Control.Registration;
namespace My_Project_PP04.Forms
{
    public partial class EntryForm : Form
    {
        public Control.Authorization.Authorization Authorization;
        public Registration Registration = new Registration();
        public EntryForm()
        {
            InitializeComponent();
            Program.AuthorizationAndRegistration = this;
            Authorization = new Control.Authorization.Authorization();
            Authorization.Registration = Registration;
        }

        private async void AuthorizationAndRegistration_Load(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            Authorization.Dock = DockStyle.Bottom;
            await Task.Delay(500);
            panelControl.Controls.Add(Authorization);



        }

        //panelTop
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTopMenu.Capture = false;
            pictureBoxLogo.Capture = false;
            panelForm.Capture = false;
            panel1.Capture = false;
            panel2.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void CrosBtn_MouseDown(object sender, MouseEventArgs e)
        {
            CrosBtn.Image = Properties.Resources.CrossLight;
        }

        private void CrosBtn_Leave(object sender, EventArgs e)
        {
            CrosBtn.Image = Properties.Resources.CrossDark;
        }

        private void CrosBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
