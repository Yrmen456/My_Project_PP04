using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Forms
{
    public partial class PatternForm : Form
    {
        public PatternForm()
        {
            InitializeComponent();
         
            topPanel.BackColor = Color.FromArgb(125, Color.Black);
            labelTitle.BackColor = Color.FromArgb(0, Color.Black);
            labelTitle.ForeColor = Color.White;
            pictureBoxLink1.BackColor = Color.FromArgb(0, Color.Black);
            pictureBoxLink2.BackColor = Color.FromArgb(0, Color.Black);
            pictureBoxLink3.BackColor = Color.FromArgb(0, Color.Black);
            panelBtn.BackColor = Color.FromArgb(0, Color.Black);
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panelBtn.Width = (this.Width / 100) * 40;
        }

        private void pictureBoxLink_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string Link = pictureBox.Tag.ToString();
            ProcessStartInfo sInfo = new ProcessStartInfo(Link);
            Process.Start(sInfo);
        }
    }
}
