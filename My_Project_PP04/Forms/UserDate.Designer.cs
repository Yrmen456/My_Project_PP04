
namespace My_Project_PP04.Forms
{
    partial class UserDate
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
            this.components = new System.ComponentModel.Container();
            My_Project_PP04.Data.ValidateTexBox.Custom custom2 = new My_Project_PP04.Data.ValidateTexBox.Custom();
            this.validateTexBox3 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox2 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox1 = new My_Project_PP04.Data.ValidateTexBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.validateTexBoxPhoneNumber = new My_Project_PP04.Data.ValidateTexBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.validateTexBoxLogin = new My_Project_PP04.Data.ValidateTexBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.validateTexBox5 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox4 = new My_Project_PP04.Data.ValidateTexBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.validateTexBox6 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox7 = new My_Project_PP04.Data.ValidateTexBox();
            this.validateTexBox8 = new My_Project_PP04.Data.ValidateTexBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.button6);
            this.panelBtn.Location = new System.Drawing.Point(590, 0);
            // 
            // validateTexBox3
            // 
            this.validateTexBox3.ArrBuilt_In = null;
            this.validateTexBox3.ArrCustom = null;
            this.validateTexBox3.Control = null;
            this.validateTexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox3.Form = null;
            this.validateTexBox3.Location = new System.Drawing.Point(34, 337);
            this.validateTexBox3.Name = "validateTexBox3";
            this.validateTexBox3.Object = null;
            this.validateTexBox3.ReadOnly = true;
            this.validateTexBox3.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox3.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox3.TabIndex = 25;
            this.validateTexBox3.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox2
            // 
            this.validateTexBox2.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Name};
            this.validateTexBox2.ArrCustom = null;
            this.validateTexBox2.Control = null;
            this.validateTexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox2.Form = null;
            this.validateTexBox2.Location = new System.Drawing.Point(34, 261);
            this.validateTexBox2.Name = "validateTexBox2";
            this.validateTexBox2.Object = null;
            this.validateTexBox2.ReadOnly = true;
            this.validateTexBox2.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox2.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox2.TabIndex = 24;
            this.validateTexBox2.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // validateTexBox1
            // 
            this.validateTexBox1.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Surname};
            this.validateTexBox1.ArrCustom = null;
            this.validateTexBox1.Control = null;
            this.validateTexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox1.Form = null;
            this.validateTexBox1.Location = new System.Drawing.Point(34, 186);
            this.validateTexBox1.Name = "validateTexBox1";
            this.validateTexBox1.Object = null;
            this.validateTexBox1.ReadOnly = true;
            this.validateTexBox1.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox1.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBox1.TabIndex = 23;
            this.validateTexBox1.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите Фамилию:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(29, 232);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(144, 25);
            this.labelLogin.TabIndex = 20;
            this.labelLogin.Text = "Введите Имя:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(29, 308);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(194, 25);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Введите Отчество:";
            // 
            // validateTexBoxPhoneNumber
            // 
            this.validateTexBoxPhoneNumber.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Phone};
            this.validateTexBoxPhoneNumber.ArrCustom = null;
            this.validateTexBoxPhoneNumber.Control = null;
            this.validateTexBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxPhoneNumber.Form = null;
            this.validateTexBoxPhoneNumber.Location = new System.Drawing.Point(34, 414);
            this.validateTexBoxPhoneNumber.Name = "validateTexBoxPhoneNumber";
            this.validateTexBoxPhoneNumber.Object = null;
            this.validateTexBoxPhoneNumber.ReadOnly = true;
            this.validateTexBoxPhoneNumber.Size = new System.Drawing.Size(413, 34);
            this.validateTexBoxPhoneNumber.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBoxPhoneNumber.TabIndex = 1115;
            this.validateTexBoxPhoneNumber.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(29, 385);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(189, 25);
            this.labelPhoneNumber.TabIndex = 1114;
            this.labelPhoneNumber.Text = "Введите Телефон:";
            // 
            // validateTexBoxLogin
            // 
            this.validateTexBoxLogin.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Email};
            this.validateTexBoxLogin.ArrCustom = null;
            this.validateTexBoxLogin.Control = null;
            this.validateTexBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBoxLogin.Form = null;
            this.validateTexBoxLogin.Location = new System.Drawing.Point(34, 490);
            this.validateTexBoxLogin.Name = "validateTexBoxLogin";
            this.validateTexBoxLogin.Object = null;
            this.validateTexBoxLogin.ReadOnly = true;
            this.validateTexBoxLogin.Size = new System.Drawing.Size(413, 34);
            this.validateTexBoxLogin.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.None;
            this.validateTexBoxLogin.TabIndex = 1117;
            this.validateTexBoxLogin.Validate = My_Project_PP04.Data.TypeValidate.Built_In;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1116;
            this.label2.Text = "Введите Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 1118;
            this.label3.Text = "Стоимость: 300 рублей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 1119;
            this.label4.Text = "Скидка: 0 рублей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 1120;
            this.label5.Text = "Итого: 300 рублей";
            // 
            // validateTexBox5
            // 
            this.validateTexBox5.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox5.ArrCustom = null;
            this.validateTexBox5.Control = null;
            this.validateTexBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox5.Form = null;
            this.validateTexBox5.Location = new System.Drawing.Point(532, 261);
            this.validateTexBox5.Name = "validateTexBox5";
            this.validateTexBox5.Object = null;
            this.validateTexBox5.ReadOnly = true;
            this.validateTexBox5.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox5.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox5.TabIndex = 1128;
            this.validateTexBox5.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox4
            // 
            this.validateTexBox4.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox4.ArrCustom = null;
            this.validateTexBox4.Control = null;
            this.validateTexBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox4.Form = null;
            this.validateTexBox4.Location = new System.Drawing.Point(532, 186);
            this.validateTexBox4.Name = "validateTexBox4";
            this.validateTexBox4.Object = null;
            this.validateTexBox4.ReadOnly = true;
            this.validateTexBox4.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox4.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox4.TabIndex = 1127;
            this.validateTexBox4.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(529, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 1129;
            this.label6.Text = "Введите Подъезд:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(529, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 1130;
            this.label7.Text = "Введите Этаж:";
            // 
            // validateTexBox6
            // 
            this.validateTexBox6.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            custom2.Error = "error";
            custom2.Regex = "^(?=.*[\\d]).{1,}$";
            this.validateTexBox6.ArrCustom = new My_Project_PP04.Data.ValidateTexBox.Custom[] {
        custom2};
            this.validateTexBox6.Control = null;
            this.validateTexBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox6.Form = null;
            this.validateTexBox6.Location = new System.Drawing.Point(532, 337);
            this.validateTexBox6.Name = "validateTexBox6";
            this.validateTexBox6.Object = null;
            this.validateTexBox6.ReadOnly = true;
            this.validateTexBox6.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox6.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox6.TabIndex = 1123;
            this.validateTexBox6.Validate = My_Project_PP04.Data.TypeValidate.Custom;
            // 
            // validateTexBox7
            // 
            this.validateTexBox7.ArrBuilt_In = new My_Project_PP04.Data.Built_In[0];
            this.validateTexBox7.ArrCustom = null;
            this.validateTexBox7.Control = null;
            this.validateTexBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox7.Form = null;
            this.validateTexBox7.Location = new System.Drawing.Point(532, 414);
            this.validateTexBox7.Name = "validateTexBox7";
            this.validateTexBox7.Object = null;
            this.validateTexBox7.ReadOnly = true;
            this.validateTexBox7.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox7.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox7.TabIndex = 1122;
            this.validateTexBox7.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // validateTexBox8
            // 
            this.validateTexBox8.ArrBuilt_In = new My_Project_PP04.Data.Built_In[] {
        My_Project_PP04.Data.Built_In.Email};
            this.validateTexBox8.ArrCustom = null;
            this.validateTexBox8.Control = null;
            this.validateTexBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.validateTexBox8.Form = null;
            this.validateTexBox8.Location = new System.Drawing.Point(532, 490);
            this.validateTexBox8.Name = "validateTexBox8";
            this.validateTexBox8.Object = null;
            this.validateTexBox8.ReadOnly = true;
            this.validateTexBox8.Size = new System.Drawing.Size(413, 34);
            this.validateTexBox8.Spaces = My_Project_PP04.Data.ValidateTexBox.YesNo.No;
            this.validateTexBox8.TabIndex = 1121;
            this.validateTexBox8.Validate = My_Project_PP04.Data.TypeValidate.None;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(529, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 1126;
            this.label8.Text = "Введите Улицу:";
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword1.Location = new System.Drawing.Point(529, 233);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(147, 25);
            this.labelPassword1.TabIndex = 1124;
            this.labelPassword1.Text = "Введите Дом:";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword2.Location = new System.Drawing.Point(529, 309);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(184, 25);
            this.labelPassword2.TabIndex = 1125;
            this.labelPassword2.Text = "Введите Комнату:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(185, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 48);
            this.button6.TabIndex = 3;
            this.button6.Text = "Назад";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(900, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 28);
            this.button1.TabIndex = 1131;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(532, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 28);
            this.button2.TabIndex = 1132;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(509, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 57);
            this.label9.TabIndex = 1133;
            this.label9.Text = "Адресс:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 35);
            this.button3.TabIndex = 1134;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 580);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 35);
            this.button4.TabIndex = 1134;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(222)))), ((int)(((byte)(50)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(782, 633);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 35);
            this.button5.TabIndex = 1135;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_Project_PP04.Properties.Resources.Новый_проект__1_;
            this.ClientSize = new System.Drawing.Size(990, 680);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.validateTexBox5);
            this.Controls.Add(this.validateTexBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.validateTexBox6);
            this.Controls.Add(this.validateTexBox7);
            this.Controls.Add(this.validateTexBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPassword1);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.validateTexBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.validateTexBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.validateTexBox3);
            this.Controls.Add(this.validateTexBox2);
            this.Controls.Add(this.validateTexBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPassword);
            this.Name = "UserDate";
            this.Text = "UserDate";
            this.Controls.SetChildIndex(this.labelPassword, 0);
            this.Controls.SetChildIndex(this.labelLogin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.validateTexBox1, 0);
            this.Controls.SetChildIndex(this.validateTexBox2, 0);
            this.Controls.SetChildIndex(this.validateTexBox3, 0);
            this.Controls.SetChildIndex(this.labelPhoneNumber, 0);
            this.Controls.SetChildIndex(this.validateTexBoxPhoneNumber, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.validateTexBoxLogin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.labelPassword2, 0);
            this.Controls.SetChildIndex(this.labelPassword1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.validateTexBox8, 0);
            this.Controls.SetChildIndex(this.validateTexBox7, 0);
            this.Controls.SetChildIndex(this.validateTexBox6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.validateTexBox4, 0);
            this.Controls.SetChildIndex(this.validateTexBox5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Data.ValidateTexBox validateTexBox3;
        internal Data.ValidateTexBox validateTexBox2;
        internal Data.ValidateTexBox validateTexBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        internal Data.ValidateTexBox validateTexBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        internal Data.ValidateTexBox validateTexBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal Data.ValidateTexBox validateTexBox5;
        internal Data.ValidateTexBox validateTexBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal Data.ValidateTexBox validateTexBox6;
        internal Data.ValidateTexBox validateTexBox7;
        internal Data.ValidateTexBox validateTexBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelPassword2;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
    }
}