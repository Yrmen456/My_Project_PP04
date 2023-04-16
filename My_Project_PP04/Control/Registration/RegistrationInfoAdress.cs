using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Control.Registration
{
    public partial class RegistrationInfoAdress : UserControl
    {
        public RegistrationInfoAdress()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.HideRegistrationInfoAdress();
        }  
        
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.Dispose();
            Program.AuthorizationAndRegistration.Registration = new Registration();
            Program.AuthorizationAndRegistration.Authorization.Registration = Program.AuthorizationAndRegistration.Registration;
            Program.AuthorizationAndRegistration.Authorization.Show();
        }
    }
}
