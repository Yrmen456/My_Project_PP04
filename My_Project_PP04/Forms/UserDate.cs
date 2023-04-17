using LibraryDataBase;
using My_Project_PP04.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Forms
{
    public partial class UserDate : PatternForm
    {
        public UserDate()
        {
            InitializeComponent();
            ShowUser();
        }

        int index = 0;
        int count = Data.Data.User.UserAdres.UserAdres.Count;
        void ShowUser()
        {
            validateTexBox1.Text = Data.Data.User.Surname;
            validateTexBox2.Text = Data.Data.User.Name;
            validateTexBox3.Text = Data.Data.User.Patronymic;
            validateTexBoxLogin.Text = Data.Data.User.Login;
            validateTexBoxPhoneNumber.Text = Data.Data.User.Phone;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            if (count < 1)
            {
                button2.Visible = false;
                button1.Visible = false;
                return;
            }
            button1.Visible = true;
            UserAdres item = Data.Data.User.UserAdres.UserAdres[index];
          
            label9.Text = "Адрес:" + item.Adress;
            validateTexBox4.Text = item.Street;
            validateTexBox5.Text = item.House;
            validateTexBox6.Text = item.Room;
            validateTexBox7.Text = item.Porth;
            validateTexBox8.Text = item.Floor;
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            index++;
            UserAdres item = Data.Data.User.UserAdres.UserAdres[index];
            label9.Text = "Адрес:"+item.Adress;
            validateTexBox4.Text = item.Street;
            validateTexBox5.Text = item.House;
            validateTexBox6.Text = item.Room;
            validateTexBox7.Text = item.Porth;
            validateTexBox8.Text = item.Floor;
            if (index >= count-1)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            UserAdres item = Data.Data.User.UserAdres.UserAdres[index];
            label9.Text = "Адрес:" + item.Adress;
            validateTexBox4.Text = item.Street;
            validateTexBox5.Text = item.House;
            validateTexBox6.Text = item.Room;
            validateTexBox7.Text = item.Porth;
            validateTexBox8.Text = item.Floor;
            if (index <= count - 1)
            {
                button1.Visible = true;
                button2.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet result = SQL.Table($"AddOrder {Data.Data.User.ID}");

        }
    }
}
