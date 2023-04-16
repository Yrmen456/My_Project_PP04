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
        public int _i;
        public int i
        {
            get => _i;
            set
            {
                label1.Text = "" + i;
                if (value != _i)
                {
                    _i = value;
                    label1.Text = "" + i;
                }
            }
        }
        public ProductListItems()
        {
            InitializeComponent();
            i = 0;
          
         
        }

        private async void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = new Panel();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
