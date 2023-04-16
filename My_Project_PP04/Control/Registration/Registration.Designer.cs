
namespace My_Project_PP04.Control.Registration
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonControl3 = new My_Project_PP04.Control.Registration.RadioButtonControl();
            this.radioButtonControl2 = new My_Project_PP04.Control.Registration.RadioButtonControl();
            this.radioButtonControl1 = new My_Project_PP04.Control.Registration.RadioButtonControl();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButtonControl3);
            this.panel1.Controls.Add(this.radioButtonControl2);
            this.panel1.Controls.Add(this.radioButtonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 60);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // radioButtonControl3
            // 
            this.radioButtonControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonControl3.AutoSize = true;
            this.radioButtonControl3.Control = null;
            this.radioButtonControl3.Location = new System.Drawing.Point(227, 23);
            this.radioButtonControl3.Name = "radioButtonControl3";
            this.radioButtonControl3.Size = new System.Drawing.Size(17, 16);
            this.radioButtonControl3.TabIndex = 3;
            this.radioButtonControl3.TabStop = true;
            this.radioButtonControl3.UseVisualStyleBackColor = true;
            this.radioButtonControl3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonControl2
            // 
            this.radioButtonControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonControl2.AutoSize = true;
            this.radioButtonControl2.Control = null;
            this.radioButtonControl2.Location = new System.Drawing.Point(194, 23);
            this.radioButtonControl2.Name = "radioButtonControl2";
            this.radioButtonControl2.Size = new System.Drawing.Size(17, 16);
            this.radioButtonControl2.TabIndex = 2;
            this.radioButtonControl2.TabStop = true;
            this.radioButtonControl2.UseVisualStyleBackColor = true;
            this.radioButtonControl2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonControl1
            // 
            this.radioButtonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonControl1.AutoSize = true;
            this.radioButtonControl1.Control = null;
            this.radioButtonControl1.Location = new System.Drawing.Point(162, 23);
            this.radioButtonControl1.Name = "radioButtonControl1";
            this.radioButtonControl1.Size = new System.Drawing.Size(17, 16);
            this.radioButtonControl1.TabIndex = 1;
            this.radioButtonControl1.TabStop = true;
            this.radioButtonControl1.UseVisualStyleBackColor = true;
            this.radioButtonControl1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(420, 390);
            this.panelControl.TabIndex = 0;
            this.panelControl.TabStop = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.Size = new System.Drawing.Size(420, 450);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panelControl;
        internal RadioButtonControl radioButtonControl3;
        internal RadioButtonControl radioButtonControl2;
        internal RadioButtonControl radioButtonControl1;
    }
}
