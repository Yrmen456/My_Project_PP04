using LibraryDataBase;
using My_Project_PP04.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private async void buttonBack_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.panelControl.Visible = false;
            Program.AuthorizationAndRegistration.Registration.HideRegistrationInfoAdress();
            await Task.Delay(100);
            Program.AuthorizationAndRegistration.panelControl.Visible = true;
           
        }  
        
        private async void buttonContinue_Click(object sender, EventArgs e)
        {


            Program.AuthorizationAndRegistration.Registration.AddUser();
            Program.AuthorizationAndRegistration.panelControl.Visible = false;
            Program.AuthorizationAndRegistration.Registration.Dispose();
            Program.AuthorizationAndRegistration.Registration = new Registration();
            Program.AuthorizationAndRegistration.Authorization.Registration = Program.AuthorizationAndRegistration.Registration;
            Program.AuthorizationAndRegistration.Authorization.Show();
            await Task.Delay(100);
            Program.AuthorizationAndRegistration.panelControl.Visible = true;
        }
    }
}
