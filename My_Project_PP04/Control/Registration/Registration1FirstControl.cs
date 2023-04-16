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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.Hide();
            Program.AuthorizationAndRegistration.Authorization.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validateTexBox1.ValidateResult.ToString()) ;
            //Program.AuthorizationAndRegistration.Registration.radioButtonControl2.Checked = true;
        }
    }
}
