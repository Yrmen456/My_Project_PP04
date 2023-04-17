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
using Newtonsoft.Json;
using LibraryDataBase;
using System.Data.SqlClient;

namespace My_Project_PP04.Control.Registration
{
    public partial class Registration3ThirdControl : UserControl
    {

        public Gender Gender;
        public Registration3ThirdControl()
        {
            InitializeComponent();
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddYears(-14);
        }
       
        private void Registration3ThirdControl_Load(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd.Add(validateTexBoxPhoneNumber);
          
            SQLCharacter();
        }
        public async void SQLCharacter()
        {

            DataSet dataSet = new DataSet();
            List<SqlParameter> ListSqlParamete = new List<SqlParameter>()
            { };
           
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select Code, Name as GenderName from Gender ", ListSqlParamete);
            });
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            if (dataSet.Tables.Count <= 0)
            {
                //MessageBox.Show("F1");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                //MessageBox.Show("F2");
                return;
            }
            dataSet.Tables[0].TableName = "Gender";
            Genders genders;
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
                      

            genders = JsonConvert.DeserializeObject<Genders>(json, settings);
            GenderRadioButton(genders);

        }
        async void GenderRadioButton(Genders genders)
        {
            panelGender.Visible = false;
            panelGender.Controls.Clear();
            List<RadioButton> radioButtonsList = new List<RadioButton>();
            await Task.Run(() => {
                for (int i = genders.Gender.Count - 1; i >= 0; i--)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Dock = DockStyle.Top;
                    radioButton.Text = genders.Gender[i].GenderName;
                    radioButton.Tag = genders.Gender[i];
                    radioButton.Padding = new Padding(2, 5, 2, 5);
                    radioButton.AutoSize = true;
                    radioButton.AutoEllipsis = true;
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                    if (i == 0)
                    {
                        radioButton.Checked = true;
                    }
       
                    radioButtonsList.Add(radioButton);
                }
            });
            panelGender.Controls.AddRange(radioButtonsList.ToArray());
            await Task.Delay(10);
            panelGender.Visible = true;
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Gender gender = (Gender)radioButton.Tag;
            if (radioButton.Checked)
            {
                Gender = gender;
            }
      
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.radioButtonControl2.Checked = true;
        }

        private async void buttonContinue_Click(object sender, EventArgs e)
        {
            bool Result = true;
            bool First = true;
            foreach (ValidateTexBox item in Program.AuthorizationAndRegistration.Registration.validateTexBoxCheckasd)
            {
                if (!item.ValidateResult)
                {
                    
                    this.Hide();
         
                    item.ThisValidate();
                    Result = false;
                    if (item.Control != null)
                    {
                        if (First)
                        {
                            item.Control.Show();
                            First = false;
                        }

                    }
                   
                    Result = false;
                }
            }
            if (!Result)
            {
                return;
            }
            Program.AuthorizationAndRegistration.panelControl.Visible = false;
            Program.AuthorizationAndRegistration.Registration.ShowRegistrationInfoAdress();
            await Task.Delay(100);
            Program.AuthorizationAndRegistration.panelControl.Visible = true;
        }

        private void buttonContinue_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Program.AuthorizationAndRegistration.Registration.radioButtonControl3.Checked = true;
            }
           
        }
    }
}
