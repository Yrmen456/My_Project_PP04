using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP04.Forms;
using LibraryDataBase;
namespace My_Project_PP04
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static EntryForm AuthorizationAndRegistration;
        public static Mian ThisMain;
        [STAThread]
        static void Main()
        {
            SQL.Conect = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=My_Project_PP04;Integrated Security=True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApplicationContext.Open(new EntryForm());
            Application.Run();
        }
        public static int formCount;
        public class MyApplicationContext : ApplicationContext
        {
            static public void Open(Form form)
            {

                form.Closed += OnFormClosed;
                formCount++;
                form.Show();
                form.Focus();
            }

            static public void OnFormClosed(object sender, EventArgs e)
            {
                formCount--;
                if (formCount <= 0)
                {
                    Application.Exit();
                }
            }
        }
    }
}
