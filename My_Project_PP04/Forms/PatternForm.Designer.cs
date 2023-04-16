
namespace My_Project_PP04.Forms
{
    partial class PatternForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.pictureBoxLink3 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLink2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLink1 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.panelBtn);
            this.topPanel.Controls.Add(this.pictureBoxLink3);
            this.topPanel.Controls.Add(this.labelTitle);
            this.topPanel.Controls.Add(this.pictureBoxLink2);
            this.topPanel.Controls.Add(this.pictureBoxLink1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1064, 91);
            this.topPanel.TabIndex = 7;
            // 
            // panelBtn
            // 
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtn.Location = new System.Drawing.Point(664, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(400, 91);
            this.panelBtn.TabIndex = 4;
            this.panelBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxLink3
            // 
            this.pictureBoxLink3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLink3.Image")));
            this.pictureBoxLink3.Location = new System.Drawing.Point(163, 9);
            this.pictureBoxLink3.Name = "pictureBoxLink3";
            this.pictureBoxLink3.Size = new System.Drawing.Size(74, 74);
            this.pictureBoxLink3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLink3.TabIndex = 3;
            this.pictureBoxLink3.TabStop = false;
            this.pictureBoxLink3.Tag = "https://web.telegram.org/";
            this.pictureBoxLink3.Click += new System.EventHandler(this.pictureBoxLink_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(448, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(184, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ЦВЕТУЧЕНО";
            // 
            // pictureBoxLink2
            // 
            this.pictureBoxLink2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLink2.Image")));
            this.pictureBoxLink2.Location = new System.Drawing.Point(83, 9);
            this.pictureBoxLink2.Name = "pictureBoxLink2";
            this.pictureBoxLink2.Size = new System.Drawing.Size(74, 74);
            this.pictureBoxLink2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLink2.TabIndex = 2;
            this.pictureBoxLink2.TabStop = false;
            this.pictureBoxLink2.Tag = "https://www.instagram.com/teddyflowers_perm/";
            this.pictureBoxLink2.Click += new System.EventHandler(this.pictureBoxLink_Click);
            // 
            // pictureBoxLink1
            // 
            this.pictureBoxLink1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLink1.Image")));
            this.pictureBoxLink1.Location = new System.Drawing.Point(3, 9);
            this.pictureBoxLink1.Name = "pictureBoxLink1";
            this.pictureBoxLink1.Size = new System.Drawing.Size(74, 74);
            this.pictureBoxLink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLink1.TabIndex = 1;
            this.pictureBoxLink1.TabStop = false;
            this.pictureBoxLink1.Tag = "https://vk.com/syrprizko";
            this.pictureBoxLink1.Click += new System.EventHandler(this.pictureBoxLink_Click);
            // 
            // PatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 549);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatternForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цветучно";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBoxLink3;
        private System.Windows.Forms.PictureBox pictureBoxLink2;
        private System.Windows.Forms.PictureBox pictureBoxLink1;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Panel panelBtn;
    }
}