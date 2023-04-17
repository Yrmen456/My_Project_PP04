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
    public partial class Registration : UserControl
    {
        public List<ValidateTexBox> validateTexBoxCheckasd = new List<ValidateTexBox>();
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
                Program.AuthorizationAndRegistration.Registration.panelControl.Visible = false;
            
                foreach (var UserControl in Program.AuthorizationAndRegistration.Registration.panelControl.Controls.OfType<UserControl>())
                {
                    if (UserControl != radioButton.Control)
                    {
                        UserControl.Hide();
                    }
           
                }
                radioButton.Control.Visible = false;
                await Task.Delay(100);
                Program.AuthorizationAndRegistration.Registration.panelControl.Controls.SetChildIndex(radioButton.Control, 0);
                radioButton.Control.Show();
                radioButton.Control.Visible = true;
                Program.AuthorizationAndRegistration.Registration.panelControl.Visible = true;

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
        public bool AddUser()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IDUser");
            dt.Columns.Add("Street");
            dt.Columns.Add("House");
            dt.Columns.Add("Room");
            dt.Columns.Add("Porth");
            dt.Columns.Add("Floor");
            dt.Rows.Add(1,registrationInfoAdress.validateTexBox1.Text, registrationInfoAdress.validateTexBox2.Text, registrationInfoAdress.validateTexBox3.Text, registrationInfoAdress.validateTexBox4.Text, registrationInfoAdress.validateTexBox5.Text);;
            List<SqlParameter> ListSqlParamete = new List<SqlParameter>()
            {
                new SqlParameter{ParameterName = "@Login", SqlDbType = SqlDbType.NVarChar, Value= registration1FirstControl.validateTexBoxLogin.Text },
                new SqlParameter{ParameterName = "@Password", SqlDbType = SqlDbType.NVarChar, Value= registration1FirstControl.validateTexBoxPassword1.Text  },
                new SqlParameter{ParameterName = "@Surname", SqlDbType = SqlDbType.NVarChar, Value= registration2SecondControl.validateTexBox1.Text  },
                new SqlParameter{ParameterName = "@Name", SqlDbType = SqlDbType.NVarChar, Value= registration2SecondControl.validateTexBox2.Text  },
                new SqlParameter{ParameterName = "@Patronymic", SqlDbType = SqlDbType.NVarChar, Value= registration2SecondControl.validateTexBox3.Text  },
                new SqlParameter{ParameterName = "@Phone", SqlDbType = SqlDbType.NVarChar, Value= registration3ThirdControl.validateTexBoxPhoneNumber.Text  },
                new SqlParameter{ParameterName = "@DataOfBirth", SqlDbType = SqlDbType.Date, Value= registration3ThirdControl.dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd") },
                new SqlParameter{ParameterName = "@Gender", SqlDbType = SqlDbType.NChar, Value= registration3ThirdControl.Gender.Code },
                new SqlParameter{ParameterName = "@UserAdress", SqlDbType = SqlDbType.Structured,
                TypeName = "dbo.UserAddressType" , Value = dt },
            };


            bool result = SQL.Query("EXEC AddUser @Login,@Password, @Surname, @Name, @Patronymic, @Phone, @DataOfBirth, @Gender, @UserAdress ", ListSqlParamete);
            MessageBox.Show(""+ result);
            return result;
        }
    }
    class RadioButtonControl : RadioButton
    {
        public UserControl Control { get; set; }
    }


}
