using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP04.Data;

namespace My_Project_PP04.Control.Registration
{
    public partial class Registration1FirstControl : UserControl
    {
        public Registration1FirstControl()
        {
            InitializeComponent();
            validateTexBoxLogin.Focus();
    
        }

        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.panelControl.Visible = false;
            Program.AuthorizationAndRegistration.Registration.Hide();
            await Task.Delay(100);
            Program.AuthorizationAndRegistration.Authorization.Show();
            await Task.Delay(10);
            Program.AuthorizationAndRegistration.panelControl.Visible = true;

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(validateTexBoxPassword1.ValidateResult.ToString()) ;
            Program.AuthorizationAndRegistration.Registration.radioButtonControl2.Checked = true;
        }

        private void Registration1FirstControl_Load(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBoxLogin);
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBoxPassword1);
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBoxPassword2);
     
        }

        private void panelInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Program.AuthorizationAndRegistration.Registration.radioButtonControl1.Checked = true;
            }
          
        }
    }
}
