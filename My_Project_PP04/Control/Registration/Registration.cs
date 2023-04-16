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
    public partial class Registration : UserControl
    {
        public Registration1FirstControl registration1FirstControl = new Registration1FirstControl();
        public Registration2SecondControl registration2SecondControl = new Registration2SecondControl();
        public Registration3ThirdControl registration3ThirdControl = new Registration3ThirdControl();
        public RegistrationInfoAdress registrationInfoAdress = new RegistrationInfoAdress();
        public Registration()
        {
            InitializeComponent();
            radioButtonControl1.Control = registration1FirstControl;
            radioButtonControl2.Control = registration2SecondControl;
            radioButtonControl3.Control = registration3ThirdControl;
   
        }

        private async void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonControl radioButton = (RadioButtonControl)sender;
            if (radioButton.Checked == true)
            {
       
                if (radioButton.Control ==null)
                {
                    return;
                }
                foreach (var UserControl in Program.AuthorizationAndRegistration.Registration.panelControl.Controls.OfType<UserControl>())
                {
                    if (UserControl != radioButton.Control)
                    {
                        UserControl.Hide();
                    }
           
                }
                radioButton.Control.Visible = false;
                await Task.Delay(10);
                Program.AuthorizationAndRegistration.Registration.panelControl.Controls.SetChildIndex(radioButton.Control, 0);
                radioButton.Control.Show();
                radioButton.Control.Visible = true;
      
                
            }
      
      
        }

        private void Registration_Load(object sender, EventArgs e)
        {        
            registration1FirstControl.Hide();
            registration2SecondControl.Hide();
            registration3ThirdControl.Hide();
            registrationInfoAdress.Hide();
            Program.AuthorizationAndRegistration.Registration.panelControl.Controls.Add(registration1FirstControl);
            Program.AuthorizationAndRegistration.Registration.panelControl.Controls.Add(registration2SecondControl);
            Program.AuthorizationAndRegistration.Registration.panelControl.Controls.Add(registration3ThirdControl);
            Program.AuthorizationAndRegistration.Registration.Controls.Add(registrationInfoAdress);
            radioButtonControl1.Checked = true;
        
        }
        public void ShowRegistrationInfoAdress()
        {
            registrationInfoAdress.Show();
            this.Controls.SetChildIndex(registrationInfoAdress, 0);
        }
        public void HideRegistrationInfoAdress()
        {
            this.Controls.SetChildIndex(registrationInfoAdress, this.Controls.Count);
            registrationInfoAdress.Hide();
        }
    }
    class RadioButtonControl : RadioButton
    {
        public UserControl Control { get; set; }
    }
}
