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

namespace My_Project_PP04.Control.Registration
{
    public partial class Registration3ThirdControl : UserControl
    {
        public Registration3ThirdControl()
        {
            InitializeComponent();
        }

        private void Registration3ThirdControl_Load(object sender, EventArgs e)
        {
            SQLCharacter();
        }
        public async void SQLCharacter()
        {

            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select Code, Name as GenderName from Gender;");
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
            dataSet.Tables[0].TableName = "genders";
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
                for (int i = genders.genders.Count - 1; i >= 0; i--)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Dock = DockStyle.Top;
                    radioButton.Text = genders.genders[i].GenderName;
                    radioButton.Tag = genders.genders[i];
                    radioButton.Padding = new Padding(2, 5, 2, 5);
                    radioButton.AutoSize = true;
                    radioButton.AutoEllipsis = true;
                    if (i == 0)
                    {
                        radioButton.Checked = true;
                    }
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
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
                MessageBox.Show(gender.Code + "/" +gender.GenderName);

            }
      
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.radioButtonControl2.Checked = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.Registration.ShowRegistrationInfoAdress();
        }
    }
}
