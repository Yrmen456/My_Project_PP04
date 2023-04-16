
namespace My_Project_PP04.Control
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.validateTexBox2 = new My_Project_PP04.Data.ValidateTexBox();
            this.btnValidatePassword1 = new My_Project_PP04.Data.BtnValidatePassword();
            this.btnPassword1 = new My_Project_PP04.Data.BtnPassword();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(262, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // validateTexBox2
            // 
            this.validateTexBox2.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox2.ArrCustom = new My_Project_PP04.Data.ValidateTexBox.Custom[0];
            this.validateTexBox2.ErrorProvider = null;
            this.validateTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox2.Location = new System.Drawing.Point(28, 59);
            this.validateTexBox2.Name = "validateTexBox2";
            this.validateTexBox2.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox2.TabIndex = 5;
            this.validateTexBox2.UseSystemPasswordChar = true;
            this.validateTexBox2.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // btnValidatePassword1
            // 
            this.btnValidatePassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidatePassword1.BackgroundImage")));
            this.btnValidatePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnValidatePassword1.Location = new System.Drawing.Point(330, 99);
            this.btnValidatePassword1.Name = "btnValidatePassword1";
            this.btnValidatePassword1.Size = new System.Drawing.Size(40, 34);
            this.btnValidatePassword1.TabIndex = 7;
            this.btnValidatePassword1.textBox = null;
            // 
            // btnPassword1
            // 
            this.btnPassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassword1.BackgroundImage")));
            this.btnPassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassword1.Location = new System.Drawing.Point(226, 98);
            this.btnPassword1.Name = "btnPassword1";
            this.btnPassword1.Size = new System.Drawing.Size(40, 34);
            this.btnPassword1.TabIndex = 8;
            this.btnPassword1.textBox = null;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnPassword1);
            this.Controls.Add(this.btnValidatePassword1);
            this.Controls.Add(this.validateTexBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(420, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Data.ValidateTexBox validateTexBox2;
        private Data.BtnValidatePassword btnValidatePassword1;
        private Data.BtnPassword btnPassword1;
    }
}
