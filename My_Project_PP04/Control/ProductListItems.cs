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

namespace My_Project_PP04.Control
{
    public partial class ProductListItems : UserControl
    {
        ProductList productList; 
        Product product;
        public ProductListItems(ProductList productList, Product product)
        {
            InitializeComponent();
            this.product = product;
            this.productList = productList;
            label1.Text = product.Name;
            label2.Text = product.Price + " руб.";
            ShowPhoto();
        }
        string startupPath = Environment.CurrentDirectory;
        async void ShowPhoto()
        {

            try
            {
                pictureBoxImg.Image = Image.FromFile($@"{startupPath}\img\{product.SCR}");
            }
            catch
            {

            }
        }
        private async void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = new Panel();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProductListItems_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundRed;
        }

        private void ProductListItems_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundLight;
        }

        private void ProductListItems_Leave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundLight;
        }

        private void panelFill_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundRed;
        }

        private void panelFill_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundLight;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Maximum >= numericUpDown1.Value + 1)
            {
                numericUpDown1.Value = numericUpDown1.Value + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Minimum <= (numericUpDown1.Value - 1))
            {
                numericUpDown1.Value = numericUpDown1.Value - 1;
            }

        }
    }
}
