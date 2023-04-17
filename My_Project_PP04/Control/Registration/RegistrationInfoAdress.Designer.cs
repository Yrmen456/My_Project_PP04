
namespace My_Project_PP04.Control.Registration
{
    partial class RegistrationInfoAdress
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
            this.components = new System.ComponentModel.Container();
            this.labelControlTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.validateTexBox5 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox4 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox3 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox2 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox1 = new My_Project_PP04.Data.ValidateTexBox();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlTitle.Location = new System.Drawing.Point(0, 0);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(420, 28);
            this.labelControlTitle.TabIndex = 20;
            this.labelControlTitle.Text = "Добавте адресс";
            this.labelControlTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.validateTexBox5);
            this.panelInfo.Controls.Add(this.validateTexBox4);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.validateTexBox3);
            this.panelInfo.Controls.Add(this.validateTexBox2);
            this.panelInfo.Controls.Add(this.validateTexBox1);
            this.panelInfo.Controls.Add(this.labelLogin);
            this.panelInfo.Controls.Add(this.buttonContinue);
            this.panelInfo.Controls.Add(this.buttonBack);
            this.panelInfo.Controls.Add(this.labelPassword1);
            this.panelInfo.Controls.Add(this.labelPassword2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 28);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(420, 422);
            this.panelInfo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите Подъезд:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Введите Этаж:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(10, 8);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(158, 25);
            this.labelLogin.TabIndex = 16;
            this.labelLogin.Text = "Введите Улицу:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Location = new System.Drawing.Point(149, 378);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(206, 38);
            this.buttonContinue.TabIndex = 5;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(13, 378);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 38);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword1.Location = new System.Drawing.Point(10, 83);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(147, 25);
            this.labelPassword1.TabIndex = 11;
            this.labelPassword1.Text = "Введите Дом:";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword2.Location = new System.Drawing.Point(10, 159);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(184, 25);
            this.labelPassword2.TabIndex = 12;
            this.labelPassword2.Text = "Введите Комнату:";
            // 
            // validateTexBox5
            // 
            this.validateTexBox5.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox5.Control = null;
            this.validateTexBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox5.Form = null;
            this.validateTexBox5.Location = new System.Drawing.Point(13, 337);
            this.validateTexBox5.Name = "validateTexBox5";
            this.validateTexBox5.Object = null;
            this.validateTexBox5.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox5.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox5.TabIndex = 18;
            this.validateTexBox5.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox4
            // 
            this.validateTexBox4.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox4.Control = null;
            this.validateTexBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox4.Form = null;
            this.validateTexBox4.Location = new System.Drawing.Point(13, 261);
            this.validateTexBox4.Name = "validateTexBox4";
            this.validateTexBox4.Object = null;
            this.validateTexBox4.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox4.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox4.TabIndex = 17;
            this.validateTexBox4.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox3
            // 
            this.validateTexBox3.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox3.Control = null;
            this.validateTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox3.Form = null;
            this.validateTexBox3.Location = new System.Drawing.Point(13, 187);
            this.validateTexBox3.Name = "validateTexBox3";
            this.validateTexBox3.Object = null;
            this.validateTexBox3.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox3.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox3.TabIndex = 3;
            this.validateTexBox3.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox2
            // 
            this.validateTexBox2.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox2.Control = null;
            this.validateTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox2.Form = null;
            this.validateTexBox2.Location = new System.Drawing.Point(13, 111);
            this.validateTexBox2.Name = "validateTexBox2";
            this.validateTexBox2.Object = null;
            this.validateTexBox2.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox2.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox2.TabIndex = 2;
            this.validateTexBox2.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox1
            // 
            this.validateTexBox1.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Email};
            this.validateTexBox1.Control = null;
            this.validateTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox1.Form = null;
            this.validateTexBox1.Location = new System.Drawing.Point(13, 36);
            this.validateTexBox1.Name = "validateTexBox1";
            this.validateTexBox1.Object = null;
            this.validateTexBox1.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox1.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox1.TabIndex = 1;
            this.validateTexBox1.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // RegistrationInfoAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.panelInfo);
            this.DoubleBuffered = true;
            this.Name = "RegistrationInfoAdress";
            this.Size = new System.Drawing.Size(420, 450);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelControlTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal Data.ValidateTexBox validateTexBox3;
        internal Data.ValidateTexBox validateTexBox2;
        internal Data.ValidateTexBox validateTexBox1;
        internal Data.ValidateTexBox validateTexBox5;
        internal Data.ValidateTexBox validateTexBox4;
    }
}
