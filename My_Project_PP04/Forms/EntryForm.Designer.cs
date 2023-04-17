
namespace My_Project_PP04.Forms
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.CrosBtn = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelForm.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrosBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.panelTopMenu);
            this.panelForm.Controls.Add(this.panel2);
            this.panelForm.Controls.Add(this.panel1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1069, 644);
            this.panelForm.TabIndex = 0;
            this.panelForm.TabStop = true;
            this.panelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.CrosBtn);
            this.panelTopMenu.Controls.Add(this.pictureBoxLogo);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1067, 40);
            this.panelTopMenu.TabIndex = 0;
            this.panelTopMenu.TabStop = true;
            this.panelTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // CrosBtn
            // 
            this.CrosBtn.BackColor = System.Drawing.Color.Transparent;
            this.CrosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CrosBtn.Image = global::My_Project_PP04.Properties.Resources.CrossDark;
            this.CrosBtn.Location = new System.Drawing.Point(1007, -1);
            this.CrosBtn.Name = "CrosBtn";
            this.CrosBtn.Size = new System.Drawing.Size(60, 40);
            this.CrosBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrosBtn.TabIndex = 2;
            this.CrosBtn.TabStop = false;
            this.CrosBtn.Click += new System.EventHandler(this.CrosBtn_Click);
            this.CrosBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CrosBtn_MouseDown);
            this.CrosBtn.MouseLeave += new System.EventHandler(this.CrosBtn_Leave);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::My_Project_PP04.Properties.Resources.icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::My_Project_PP04.Properties.Resources.background_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(815, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 670);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::My_Project_PP04.Properties.Resources.background_0;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Location = new System.Drawing.Point(-129, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 563);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Location = new System.Drawing.Point(510, 82);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(420, 450);
            this.panelControl.TabIndex = 2;
            this.panelControl.TabStop = true;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1069, 644);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AuthorizationAndRegistration_Load);
            this.panelForm.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CrosBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox CrosBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel panelControl;
    }
}