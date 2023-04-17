
namespace My_Project_PP04.Control.Registration
{
    partial class Registration2SecondControl
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
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
            this.labelControlTitle.Size = new System.Drawing.Size(420, 118);
            this.labelControlTitle.TabIndex = 20;
            this.labelControlTitle.Text = "Регистрация";
            this.labelControlTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.validateTexBox3);
            this.panelInfo.Controls.Add(this.validateTexBox2);
            this.panelInfo.Controls.Add(this.validateTexBox1);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.buttonContinue);
            this.panelInfo.Controls.Add(this.buttonBack);
            this.panelInfo.Controls.Add(this.labelLogin);
            this.panelInfo.Controls.Add(this.labelPassword);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 118);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(420, 272);
            this.panelInfo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите Фамилию:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Location = new System.Drawing.Point(149, 228);
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
            this.buttonBack.Location = new System.Drawing.Point(13, 228);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 38);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(10, 83);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(144, 25);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Введите Имя:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(10, 159);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(194, 25);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Введите Отчество:";
            // 
            // validateTexBox3
            // 
            this.validateTexBox3.ArrBuilt_In = null;
            this.validateTexBox3.ArrCustom = null;
            this.validateTexBox3.Control = this;
            this.validateTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox3.Form = null;
            this.validateTexBox3.Location = new System.Drawing.Point(15, 188);
            this.validateTexBox3.Name = "validateTexBox3";
            this.validateTexBox3.Object = null;
            this.validateTexBox3.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox3.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox3.TabIndex = 19;
            this.validateTexBox3.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox2
            // 
            this.validateTexBox2.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Name};
            this.validateTexBox2.ArrCustom = null;
            this.validateTexBox2.Control = this;
            this.validateTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox2.Form = null;
            this.validateTexBox2.Location = new System.Drawing.Point(15, 112);
            this.validateTexBox2.Name = "validateTexBox2";
            this.validateTexBox2.Object = null;
            this.validateTexBox2.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox2.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox2.TabIndex = 18;
            this.validateTexBox2.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // validateTexBox1
            // 
            this.validateTexBox1.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Surname};
            this.validateTexBox1.ArrCustom = null;
            this.validateTexBox1.Control = this;
            this.validateTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox1.Form = null;
            this.validateTexBox1.Location = new System.Drawing.Point(15, 37);
            this.validateTexBox1.Name = "validateTexBox1";
            this.validateTexBox1.Object = null;
            this.validateTexBox1.Size = new System.Drawing.Size(342, 34);
            this.validateTexBox1.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox1.TabIndex = 17;
            this.validateTexBox1.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // Registration2SecondControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.panelInfo);
            this.DoubleBuffered = true;
            this.Name = "Registration2SecondControl";
            this.Size = new System.Drawing.Size(420, 390);
            this.Load += new System.EventHandler(this.Registration2SecondControl_Load);
            this.VisibleChanged += new System.EventHandler(this.Registration2SecondControl_VisibleChanged);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelControlTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        internal Data.ValidateTexBox validateTexBox3;
        internal Data.ValidateTexBox validateTexBox2;
        internal Data.ValidateTexBox validateTexBox1;
    }
}
