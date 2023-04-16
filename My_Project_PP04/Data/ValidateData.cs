using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace My_Project_PP04.Data
{
    class ValidateData
    {
        public static void Validate(ValidateTexBox textBox)
        {
          
            switch (textBox.Validate)
            {
                case TypeValidate.None:
                    return;
                case TypeValidate.Built_In:
                    ValidateBuilt_In(textBox);
                    break;
                case TypeValidate.Custom:
                    ValidateCustom(textBox);
                    break;
                case TypeValidate.Double:
                    ValidateBuilt_In(textBox);
                    ValidateCustom(textBox);
                    break;
            }
        }

        public static void ValidateBuilt_In(ValidateTexBox textBox)
        {
            foreach (Built_In item in textBox.ArrBuilt_In)
            {
                switch (item)
                {
                    case Built_In.Login:
                        textBox.ValidateResult = ValidateLogin(textBox);
                        break;
                    case Built_In.Password:
                        textBox.ValidateResult = ValidatePassword(textBox);
                        break;
                    case Built_In.Email:
                        textBox.ValidateResult = ValidateEmail(textBox);
                        break;
                    case Built_In.Surname:
                        textBox.ValidateResult = true;
                        break;
                    case Built_In.Name:
                        textBox.ValidateResult = true;
                        break;
                    case Built_In.Patronymic:
                        textBox.ValidateResult = true;
                        break;
                    case Built_In.Phone:
                        textBox.ValidateResult = true;
                        break;
                }
                if (!textBox.ValidateResult)
                {
                    break;
                }
            }
        }

        public static void ValidateCustom(ValidateTexBox textBox)
        { 

        }
        
        public static bool ValidateLogin(ValidateTexBox textBox)
        {
            bool Result = false;
            if (textBox.ErrorProvider != null)
            {
                if (!Result)
                {
                    textBox.ErrorProvider.SetError(textBox, "Некорретный возраст1!");
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }
        public static bool ValidatePassword(ValidateTexBox textBox)
        {
            bool Result = false;
            if (textBox.ErrorProvider != null)
            {
                if (!Result)
                {
                    textBox.ErrorProvider.SetError(textBox, "Некорретный возраст2!");
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }
        public static bool ValidateEmail(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,3}))$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                if (!Result)
                {
                    textBox.ErrorProvider.SetError(textBox, "Некорретный возраст1!");
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }
    }


    class ValidateTexBox : TextBox
    {
        public ErrorProvider ErrorProvider { get; set; }
        public TypeValidate Validate { get; set; }
        public Built_In[] ArrBuilt_In { get; set; }
        public Custom[] ArrCustom { get; set; }
        public bool ValidateResult;
        protected internal class Custom
        {
            public string Regex { get; set; }
            public int MinLenght { get; set; }
            public int MaxLenght { get; set; }
            public YesNo Spaces { get; set; }
            public string Error { get; set; }
            protected internal enum YesNo
            {
                None,
                Yes,
                No
            }
        }

        public ValidateTexBox()
        {
            this.Validating += ValidateTexBox_Validating;
            this.TextChanged += validateTexBox_TextChanged;
        }
        private void ValidateTexBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateData.Validate(this);
        }
        private void validateTexBox_TextChanged(object sender, EventArgs e)
        {
            ValidateData.Validate(this);
        }
    }
    
    public enum TypeValidate
    {
        None,
        Built_In,
        Custom,
        Double,
    }
  
    public enum Built_In
    {
        Login,
        Password,
        Email,
        Surname,
        Name,
        Patronymic,
        Phone
    }
}
