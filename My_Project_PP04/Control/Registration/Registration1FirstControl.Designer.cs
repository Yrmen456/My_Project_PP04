
namespace My_Project_PP04.Control.Registration
{
    partial class Registration1FirstControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration1FirstControl));
            this.labelControlTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.validateTexBoxPassword2 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBoxPassword1 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBoxLogin = new My_Project_PP04.Data.ValidateTexBox();
            this.btnValidatePassword2 = new My_Project_PP04.Data.BtnValidatePassword();
            this.btnValidatePassword1 = new My_Project_PP04.Data.BtnValidatePassword();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
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
            this.labelControlTitle.TabIndex = 18;
            this.labelControlTitle.Text = "Регистрация";
            this.labelControlTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.validateTexBoxPassword2);
            this.panelInfo.Controls.Add(this.validateTexBoxPassword1);
            this.panelInfo.Controls.Add(this.validateTexBoxLogin);
            this.panelInfo.Controls.Add(this.btnValidatePassword2);
            this.panelInfo.Controls.Add(this.btnValidatePassword1);
            this.panelInfo.Controls.Add(this.labelLogin);
            this.panelInfo.Controls.Add(this.buttonContinue);
            this.panelInfo.Controls.Add(this.buttonBack);
            this.panelInfo.Controls.Add(this.labelPassword1);
            this.panelInfo.Controls.Add(this.labelPassword2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 118);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(420, 272);
            this.panelInfo.TabIndex = 19;
            this.panelInfo.VisibleChanged += new System.EventHandler(this.panelInfo_VisibleChanged);
            // 
            // validateTexBoxPassword2
            // 
            this.validateTexBoxPassword2.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Password};
            this.validateTexBoxPassword2.ArrCustom = null;
            this.validateTexBoxPassword2.Control = this;
            this.validateTexBoxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxPassword2.Form = null;
            this.validateTexBoxPassword2.Location = new System.Drawing.Point(15, 187);
            this.validateTexBoxPassword2.Name = "validateTexBoxPassword2";
            this.validateTexBoxPassword2.Object = null;
            this.validateTexBoxPassword2.Size = new System.Drawing.Size(342, 34);
            this.validateTexBoxPassword2.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBoxPassword2.TabIndex = 19;
            this.validateTexBoxPassword2.UseSystemPasswordChar = true;
            this.validateTexBoxPassword2.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // validateTexBoxPassword1
            // 
            this.validateTexBoxPassword1.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Password};
            this.validateTexBoxPassword1.ArrCustom = null;
            this.validateTexBoxPassword1.Control = this;
            this.validateTexBoxPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxPassword1.Form = null;
            this.validateTexBoxPassword1.Location = new System.Drawing.Point(15, 111);
            this.validateTexBoxPassword1.Name = "validateTexBoxPassword1";
            this.validateTexBoxPassword1.Object = null;
            this.validateTexBoxPassword1.Size = new System.Drawing.Size(342, 34);
            this.validateTexBoxPassword1.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBoxPassword1.TabIndex = 18;
            this.validateTexBoxPassword1.UseSystemPasswordChar = true;
            this.validateTexBoxPassword1.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // validateTexBoxLogin
            // 
            this.validateTexBoxLogin.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Email};
            this.validateTexBoxLogin.ArrCustom = null;
            this.validateTexBoxLogin.Control = this;
            this.validateTexBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxLogin.Form = null;
            this.validateTexBoxLogin.Location = new System.Drawing.Point(15, 37);
            this.validateTexBoxLogin.Name = "validateTexBoxLogin";
            this.validateTexBoxLogin.Object = null;
            this.validateTexBoxLogin.Size = new System.Drawing.Size(342, 34);
            this.validateTexBoxLogin.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBoxLogin.TabIndex = 17;
            this.validateTexBoxLogin.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // btnValidatePassword2
            // 
            this.btnValidatePassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidatePassword2.BackgroundImage")));
            this.btnValidatePassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnValidatePassword2.Location = new System.Drawing.Point(377, 187);
            this.btnValidatePassword2.Name = "btnValidatePassword2";
            this.btnValidatePassword2.Size = new System.Drawing.Size(40, 34);
            this.btnValidatePassword2.TabIndex = 7;
            this.btnValidatePassword2.textBox = this.validateTexBoxPassword2;
            // 
            // btnValidatePassword1
            // 
            this.btnValidatePassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidatePassword1.BackgroundImage")));
            this.btnValidatePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnValidatePassword1.Location = new System.Drawing.Point(377, 111);
            this.btnValidatePassword1.Name = "btnValidatePassword1";
            this.btnValidatePassword1.Size = new System.Drawing.Size(40, 34);
            this.btnValidatePassword1.TabIndex = 7;
            this.btnValidatePassword1.textBox = this.validateTexBoxPassword1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(10, 8);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(158, 25);
            this.labelLogin.TabIndex = 16;
            this.labelLogin.Text = "Введите Логин:";
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
            this.buttonBack.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword1.Location = new System.Drawing.Point(10, 83);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(170, 25);
            this.labelPassword1.TabIndex = 11;
            this.labelPassword1.Text = "Введите Пароль:";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword2.Location = new System.Drawing.Point(10, 159);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(194, 25);
            this.labelPassword2.TabIndex = 12;
            this.labelPassword2.Text = "Повторите Пароль:";
            // 
            // Registration1FirstControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.panelInfo);
            this.DoubleBuffered = true;
            this.Name = "Registration1FirstControl";
            this.Size = new System.Drawing.Size(420, 390);
            this.Load += new System.EventHandler(this.Registration1FirstControl_Load);
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
        private Data.BtnValidatePassword btnValidatePassword2;
        private Data.BtnValidatePassword btnValidatePassword1;
        internal Data.ValidateTexBox validateTexBoxPassword2;
        internal Data.ValidateTexBox validateTexBoxPassword1;
        internal Data.ValidateTexBox validateTexBoxLogin;
    }
}
