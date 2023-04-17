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
    public partial class CategoriesListItems : UserControl
    {
        Category category;
        public CategoriesListItems(CategoriesList categoriesList, Category category)
        {
            InitializeComponent();
            label1.Text = category.CategorieName;
            this.category = category;
            ShowPhoto();
    
        }
        string startupPath = Environment.CurrentDirectory;
        async void ShowPhoto()
        {
          
            try
            {
                pictureBoxImg.Image = Image.FromFile($@"{startupPath}\img\{category.CategorieSCR}");
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

        private void CategoriesListItems_MouseHover(object sender, EventArgs e)
        {
        
          
        }

       
        private void panelFill_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundRed;
        }
        private void panelFill_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BackgroundLight;
        }
        private void panelFill_Click(object sender, EventArgs e)
        {
            Program.ThisMain.panelControl.Controls.Clear();
            ProductList ProductList = new ProductList(category);
            ProductList.Dock = DockStyle.Fill;
            ProductList.Name = "ProductList";
            Program.ThisMain.panelControl.Controls.Add(ProductList);
        }


    }
}
