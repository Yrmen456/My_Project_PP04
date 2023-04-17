using My_Project_PP04.Control;
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
    public partial class Basket : PatternForm
    {
        public PanelTopBtn panelTopBtn = new PanelTopBtn();
        public Basket()
        {
            InitializeComponent();
            Program.Basket = this;
            panelBtn.Controls.Add(panelTopBtn.panel3);
            panelTopBtn.button6.Click += buttonExit_Click;
            Program.Basket.panelBtn.Controls.Add(Program.ThisMain.panelTopBtn.panel3);
            Program.ThisMain.panelTopBtn.button5.Click += buttonBasket_Click;
            Program.ThisMain.panelTopBtn.button6.Click += buttonBack_Click;
            Program.Basket.panelTopBtn.panel2.Show();
            
        }
        private void Basket_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }

        public void ShowProduct()
        {
            Program.Basket.panelTopBtn.ShowPriceBasket(Program.ThisMain.panelTopBtn.button5, "Оформить заказ");
            panelControl.Controls.Clear();
            UserProductList UserProductList = new UserProductList();
            UserProductList.Dock = DockStyle.Fill;
            UserProductList.Name = "UserProductList";
            panelControl.Controls.Add(UserProductList);
        }
        private void buttonBasket_Click(object sender, EventArgs e)
        {
            UserDate userDate = new UserDate();
            userDate.ShowDialog();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close();
            if (Program.ThisMain.IsDisposed)
            {
                Program.MyApplicationContext.Open(new Main());
            }
            else
            {
                Program.ThisMain.Show();
                Program.ThisMain.Focus();
            }
      
        

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
        
            if (Program.ThisMain ==null || Program.ThisMain.IsDisposed)
            {
                
                Program.MyApplicationContext.Open(new Main());
                
            }
            Program.MyApplicationContext.Open(new Main());
            this.Close();
        
        }

        private void Basket_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Basket_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
