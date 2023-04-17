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
using LibraryDataBase;
using My_Project_PP04.Control.Registration;
using My_Project_PP04.Data;
using My_Project_PP04.Forms;
using Newtonsoft.Json;

namespace My_Project_PP04.Control.Authorization
{
    public partial class Authorization : UserControl
    {
        public My_Project_PP04.Control.Registration.Registration Registration;
        public Authorization()
        {
            InitializeComponent();
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
       

        private async void buttonRegistration_Click(object sender, EventArgs e)
        {
            Program.AuthorizationAndRegistration.panelControl.Visible = false;
            this.Hide();
    
            Registration.Dock = DockStyle.Bottom;
            Program.AuthorizationAndRegistration.panelControl.Controls.Add(Registration);
            await Task.Delay(100);
            Registration.Show();
            await Task.Delay(10);
            Program.AuthorizationAndRegistration.panelControl.Visible = true;


        }
   

        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() => {
                dataSet = SQL.Table($@"Select Users.ID, Users.Login, Users.Password, Users.Surname, Users.Name,
                Users.Patronymic,Users.DataOfBirth,Users.Phone, Users.Gender as 'GenderCode', Gender.Name as 'Gender', Users.Roll as 'Role' from Users 
                Inner Join Gender Gender on Gender.Code = Users.Gender
                Inner Join Role Role on Role.ID = Users.Roll
                where Login = '{textBoxLogin.Text}' and Password = '{textBoxPassword.Text}';
                Select * from UserAddress
                Inner Join Users Users on Users.ID = UserAddress.IDUser
                where Login = '{textBoxLogin.Text}' and Password = '{textBoxPassword.Text}';
                ");
            });
            if (dataSet.Tables.Count <= 0)
            {
                MessageBox.Show("что - то пошло не так");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Логин или проль введен неверно");
                return;
            }
            string json = JsonConvert.SerializeObject(dataSet.Tables[0], Formatting.Indented);
            json = json.Trim('[', ']');
            UserData user = new UserData();
            user = JsonConvert.DeserializeObject<UserData>(json);
            dataSet.Tables[1].TableName = "UserAdres";
            string json2 = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            user.UserAdres = JsonConvert.DeserializeObject<UserAddresses>(json2);
            Data.Data.User = user;
            Program.MyApplicationContext.Open(new Main());
            Program.AuthorizationAndRegistration.Close();
        }
    }
}
