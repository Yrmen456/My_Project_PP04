
namespace My_Project_PP04.Forms
{
    partial class Basket
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 91);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1064, 458);
            this.panelControl.TabIndex = 8;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 549);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1082, 596);
            this.Name = "Basket";
            this.Text = "Basket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Basket_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Basket_FormClosed);
            this.Load += new System.EventHandler(this.Basket_Load);
            this.Controls.SetChildIndex(this.panelControl, 0);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelControl;
    }
}