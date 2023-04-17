
namespace My_Project_PP04.Control
{
    partial class CategoriesListItems
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesListItems));
            this.panelFill = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.BurlyWood;
            this.panelFill.Controls.Add(this.label1);
            this.panelFill.Controls.Add(this.panel1);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(10, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(240, 420);
            this.panelFill.TabIndex = 5;
            this.panelFill.Click += new System.EventHandler(this.panelFill_Click);
            this.panelFill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseDown);
            this.panelFill.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 122);
            this.label1.TabIndex = 7;
            this.label1.Text = "150 руб.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.panelFill_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 260);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panelFill_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseUp);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImg.Image")));
            this.pictureBoxImg.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(260, 260);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImg.TabIndex = 7;
            this.pictureBoxImg.TabStop = false;
            this.pictureBoxImg.Click += new System.EventHandler(this.panelFill_Click);
            this.pictureBoxImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseDown);
            this.pictureBoxImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFill_MouseUp);
            // 
            // CategoriesListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::My_Project_PP04.Properties.Resources.BackgroundLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.panelFill);
            this.DoubleBuffered = true;
            this.Name = "CategoriesListItems";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Size = new System.Drawing.Size(260, 420);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.MouseHover += new System.EventHandler(this.CategoriesListItems_MouseHover);
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
