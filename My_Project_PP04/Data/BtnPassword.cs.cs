using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Data
{
    class BtnPassword : Panel
    {
        bool visible_password_click = true;
        public TextBox textBox { get; set; }
        public BtnPassword()
        {
            this.BackgroundImage = Properties.Resources.Close;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Location = new System.Drawing.Point(370, 268);
            this.Name = "visiblePassword";
            this.Size = new System.Drawing.Size(40, 34);
            this.Click += new System.EventHandler(this.visible_password_Click);
           
        }
        private void visible_password_Click(object sender, EventArgs e)
        {
            if (textBox == null)
            {
                return;
            }
            if (visible_password_click)
            {

                visible_password_click = false;
                textBox.UseSystemPasswordChar = false;
                this.BackgroundImage = Properties.Resources.Open;
            }
            else
            {
                visible_password_click = true;
                textBox.UseSystemPasswordChar = true;
                this.BackgroundImage = Properties.Resources.Close;
            }
        }
    }

    class BtnValidatePassword : Panel
    {
        bool visible_password_click = true;
        public TextBox textBox { get; set; }
        public BtnValidatePassword()
        {
            this.BackgroundImage = Properties.Resources.Close;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Location = new System.Drawing.Point(370, 268);
            this.Name = "visiblePassword";
            this.Size = new System.Drawing.Size(40, 34);
            this.TabIndex = 7;
            this.Click += new System.EventHandler(this.visible_password_Click);

        }
        private void visible_password_Click(object sender, EventArgs e)
        {
            if (textBox == null)
            {
                return;
            }
            if (visible_password_click)
            {

                visible_password_click = false;
                textBox.UseSystemPasswordChar = false;
                this.BackgroundImage = Properties.Resources.Open;
            }
            else
            {
                visible_password_click = true;
                textBox.UseSystemPasswordChar = true;
                this.BackgroundImage = Properties.Resources.Close;
            }
        }
    }
}
