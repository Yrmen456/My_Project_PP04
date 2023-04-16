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
namespace My_Project_PP04.Forms
{
    public partial class Mian : PatternForm
    {
        public Mian()
        {
            InitializeComponent();

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
            ProductList ProductList = new ProductList();
            ProductList.Dock = DockStyle.Fill;
            ProductList.Name = "ProductList";
            panelControl.Controls.Add(ProductList); 
        }
   
    }
}
