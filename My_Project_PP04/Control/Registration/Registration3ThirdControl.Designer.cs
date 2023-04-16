
namespace My_Project_PP04.Control.Registration
{
    partial class Registration3ThirdControl
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
            this.labelControlTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panelGender = new System.Windows.Forms.Panel();
            this.validateTexBoxPhoneNumber = new My_Project_PP04.Data.ValidateTexBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlTitle.Location = new System.Drawing.Point(0, 0);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(420, 83);
            this.labelControlTitle.TabIndex = 20;
            this.labelControlTitle.Text = "Регистрация";
            this.labelControlTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.dateTimePickerDateOfBirth);
            this.panelInfo.Controls.Add(this.panelGender);
            this.panelInfo.Controls.Add(this.validateTexBoxPhoneNumber);
            this.panelInfo.Controls.Add(this.labelPhoneNumber);
            this.panelInfo.Controls.Add(this.buttonContinue);
            this.panelInfo.Controls.Add(this.buttonBack);
            this.panelInfo.Controls.Add(this.labelDateOfBirth);
            this.panelInfo.Controls.Add(this.labelGender);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 83);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(420, 307);
            this.panelInfo.TabIndex = 21;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(13, 111);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(342, 34);
            this.dateTimePickerDateOfBirth.TabIndex = 2;
            // 
            // panelGender
            // 
            this.panelGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGender.AutoScroll = true;
            this.panelGender.BackColor = System.Drawing.Color.Transparent;
            this.panelGender.Location = new System.Drawing.Point(15, 188);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(340, 66);
            this.panelGender.TabIndex = 17;
            // 
            // validateTexBoxPhoneNumber
            // 
            this.validateTexBoxPhoneNumber.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBoxPhoneNumber.ArrCustom = new My_Project_PP04.Data.ValidateTexBox.Custom[0];
            this.validateTexBoxPhoneNumber.ErrorProvider = null;
            this.validateTexBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxPhoneNumber.Location = new System.Drawing.Point(13, 36);
            this.validateTexBoxPhoneNumber.Name = "validateTexBoxPhoneNumber";
            this.validateTexBoxPhoneNumber.Size = new System.Drawing.Size(342, 34);
            this.validateTexBoxPhoneNumber.TabIndex = 1;
            this.validateTexBoxPhoneNumber.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(10, 8);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(189, 25);
            this.labelPhoneNumber.TabIndex = 16;
            this.labelPhoneNumber.Text = "Введите Телефон:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Location = new System.Drawing.Point(149, 263);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(206, 38);
            this.buttonContinue.TabIndex = 1112;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(13, 263);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 38);
            this.buttonBack.TabIndex = 1111;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(10, 83);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(251, 25);
            this.labelDateOfBirth.TabIndex = 11;
            this.labelDateOfBirth.Text = "Введите Дату Рождения:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(10, 159);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(153, 25);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Выберите Пол:";
            // 
            // Registration3ThirdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControlTitle);
            this.Controls.Add(this.panelInfo);
            this.DoubleBuffered = true;
            this.Name = "Registration3ThirdControl";
            this.Size = new System.Drawing.Size(420, 390);
            this.Load += new System.EventHandler(this.Registration3ThirdControl_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelControlTitle;
        private System.Windows.Forms.Panel panelInfo;
        private Data.ValidateTexBox validateTexBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Panel panelGender;
    }
}
