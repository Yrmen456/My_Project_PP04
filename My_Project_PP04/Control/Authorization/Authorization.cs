using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP04.Control.Registration;
using My_Project_PP04.Data;

namespace My_Project_PP04.Control.Authorization
{
    public partial class Authorization : UserControl
    {
        public My_Project_PP04.Control.Registration.Registration Registration;
        public Authorization()
        {
            InitializeComponent();
            textBoxLogin.Validating += textBoxLogin_Validating;
            textBoxPassword.Validating += textBoxPassword_Validating;
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
       

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Registration.Dock = DockStyle.Bottom;
            Program.AuthorizationAndRegistration.panelControl.Controls.Add(Registration);
            Registration.Show();

        }
        private void textBoxLogin_Validating(object sender, CancelEventArgs e)
        {
            //if (String.IsNullOrEmpty(textBoxLogin.Text))
            //{
            //    errorProvider1.SetError(textBoxLogin, "Не указано имя!");
            //}
            //else if (textBoxLogin.Text.Length < 4)
            //{
            //    errorProvider1.SetError(textBoxLogin, "Слишком короткое имя!");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
      
        }
        
        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            //int age = 0;
            //if (String.IsNullOrEmpty(textBoxPassword.Text))
            //{
            //    errorProvider1.SetError(textBoxPassword, "Не указан возраст!");
            //}
            //else if (!Int32.TryParse(textBoxPassword.Text, out age))
            //{
            //    errorProvider1.SetError(textBoxPassword, "Некорретный возраст!");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show("dsa");
        }
    }
}
