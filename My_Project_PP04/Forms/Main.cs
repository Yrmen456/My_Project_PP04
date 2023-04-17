using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP04.Control;
using My_Project_PP04.Data;

namespace My_Project_PP04.Forms
{
    public partial class Main : PatternForm
    {
        public PanelTopBtn panelTopBtn = new PanelTopBtn();
        public CategoriesList CategoriesList;
        public ProductList ProductList;
        public Main()
        {
            InitializeComponent();
            
            Program.ThisMain = this;
            switch (Data.Data.User.Roll)
            {
                case Role.Admin:
                    ShowRoleAdmin();
                    break;
                case Role.Client:
                    ShowRoleClient();
                    break;
                default:
                    ShowRoleClient();
                    break;
            }
            panelBtn.Controls.Add(panelTopBtn.panel1);
            panelTopBtn.button1.Click += buttonExit_Click;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Program.MyApplicationContext.Open(new EntryForm());
            this.Close();
        }

        void ShowRoleAdmin()
        {

        }
        void ShowRoleClient()
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            CategoriesList CategoriesList = new CategoriesList();
            CategoriesList.Dock = DockStyle.Fill;
            CategoriesList.Name = "CategoriesList";
            panelControl.Controls.Add(CategoriesList); 
        }
    }
}
