using LibraryDataBase;
using My_Project_PP04.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace My_Project_PP04.Forms
{
    public partial class UserDate : PatternForm
    {
        public UserDate()
        {
            InitializeComponent();
            ShowUser();
            ShowPriceBasket();
        }

        int index = 0;
        int count = Data.Data.User.UserAdres.UserAdres.Count;

        public async void ShowPriceBasket()
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select Sum(Basket.Count * Product.Price) from Basket
                Inner Join Product Product on Product.ID = Basket.ProductID 
                where Basket.UserID = {Data.Data.User.ID};");
            });

            if (dataSet.Tables.Count <= 0)
            {
                MessageBox.Show("F1");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("F2");
                return;
            }
            var Result = dataSet.Tables[0].Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            label3.Text = $"Стоимость: {Result[0]} руб.";
            label5.Text = $"Итого: {Result[0]} руб.";
        }
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
            Aderes = item.Adress;
            label9.Text = "Адрес:" + item.Adress;
            validateTexBox4.Text = item.Street;
            validateTexBox5.Text = item.House;
            validateTexBox6.Text = item.Room;
            validateTexBox7.Text = item.Porth;
            validateTexBox8.Text = item.Floor;
                
            
        }
        string Aderes = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            index++;
            UserAdres item = Data.Data.User.UserAdres.UserAdres[index];
            label9.Text = "Адрес:"+item.Adress;
            Aderes = item.Adress;
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
            Aderes = item.Adress;
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
            Program.Basket.userDate = new UserDate();
            this.Close();

        }
        string startupPath = Environment.CurrentDirectory;
        private void button5_Click(object sender, EventArgs e)
        {
            DataSet result = SQL.Table($"AddOrder {Data.Data.User.ID}");
            if (result.Tables.Count < 2)
            {
                return;
            }
            Program.Basket.ShowProduct();
            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = startupPath + @"\Resources\NewCheque.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                // Делаем копию 
                doc.SaveAs2(startupPath + @"\NewChequeCopy.docx");

                doc.Close();
                doc = null;
            }
            catch
            {
                doc = null;
                return;
            }
          
           
            try
            {
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = startupPath + @"\NewChequeCopy.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                Word.Range range = app.Selection.Range;
                Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
                System.Data.DataTable dataTable = null;


                int columns = result.Tables[1].Columns.Count;
                //-1 Потому что есть доп строка куда добоваляются товары
                int rows = result.Tables[1].Rows.Count;
                Word.Table table = doc.Tables[1];
                Random random = new Random();
                var GroupInfo2 = result.Tables[0].Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                string Number = random.Next(1, 999999).ToString();
                string Date = DateTime.Now.ToString("dd.MM.yyyy");
                doc.Bookmarks.get_Item("Number").Range.Text = GroupInfo2[0];
                doc.Bookmarks.get_Item("Date").Range.Text = Date;
                doc.Bookmarks.get_Item("Client").Range.Text = $"{Data.Data.User.Surname} {Data.Data.User.Name} {Data.Data.User.Patronymic}";
                doc.Bookmarks.get_Item("Adress").Range.Text = $"{Aderes}";
                doc.Bookmarks.get_Item("Price").Range.Text = GroupInfo2[3];
                for (int j = 0; j < rows; j++)
                {
                    // Add row to table
                    var GroupInfo = result.Tables[1].Rows[j].ItemArray.Select(x => x.ToString()).ToArray();
                    table.Rows.Add();
                    table.Cell(j + 2, 1).Range.Text = GroupInfo[5];
                    table.Cell(j + 2, 2).Range.Text = GroupInfo[3];
                    table.Cell(j + 2, 3).Range.Text = GroupInfo[7];
                    table.Cell(j + 2, 4).Range.Text = "" + (int.Parse(GroupInfo[3]) * int.Parse(GroupInfo[7]));


                }
                //table.Rows.Add();
                //table.Cell(rows + 2, 1).Range.Text = "Итог:";
                //table.Cell(rows + 2, 2).Range.Text = "1000 руб";


                string Name = DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss" + random.Next(1, 10000));
                doc.SaveAs2(startupPath + $@"\Cheque_word\Чек {Name}.docx");
                doc.SaveAs2(startupPath + $@"\Cheque_pdf\Чек {Name}.pdf", Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);

                doc.Close();
                doc = null;
                SendEmailAsync(startupPath + $@"\Cheque_word\Чек {Name}.docx").GetAwaiter();
            }
            catch (Exception ex)
            {

                doc.Close();
                doc = null;
                MessageBox.Show("Во время выполнения произошла ошибка! \n" + ex);
                Console.ReadLine();
            }
            
        }
        private static async Task SendEmailAsync(string FilePatch)
        {

            SmtpClient mySmtpClient = new SmtpClient("smtp.mail.ru");
            // set smtp-client with basicAuthentication
            mySmtpClient.UseDefaultCredentials = false;
            mySmtpClient.EnableSsl = true;
            System.Net.NetworkCredential basicAuthenticationInfo = new
               System.Net.NetworkCredential("estnewemail76@mail.ru", "XZJhikfnRQbdpT3Bypv3");
            mySmtpClient.Credentials = basicAuthenticationInfo;
            // add from,to mailaddresses
            MailAddress from = new MailAddress("estnewemail76@mail.ru", "Flowar");
            MailAddress to = new MailAddress("estnewemail76@mail.ru", "Client");
            MailMessage myMail = new System.Net.Mail.MailMessage(from, to);
            myMail.Attachments.Add(new Attachment(FilePatch));
            // add ReplyTo
            MailAddress replyTo = new MailAddress("testnewemail76@gmail.com");
            myMail.ReplyToList.Add(replyTo);
            // set subject and encoding
            myMail.Subject = "Test message";
            myMail.SubjectEncoding = System.Text.Encoding.UTF8;
            // set body-message and encoding
            myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            // text or html
            myMail.IsBodyHtml = true;
            mySmtpClient.Send(myMail);
            MessageBox.Show("Письмо отправлено");




        }
    }
}
