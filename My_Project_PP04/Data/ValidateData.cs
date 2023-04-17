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
                    if (!textBox.ValidateResult)
                    {
                        return;
                    }
                    ValidateCustom(textBox);
                    break;
            }
        
        }

        public static void Spaces(ValidateTexBox textBox)
        {
            switch (textBox.Spaces)
            {
                case ValidateTexBox.YesNo.None:
                    return;
                case ValidateTexBox.YesNo.Yes:
                    break;
                case ValidateTexBox.YesNo.No:
                    SpacesClear(textBox);
                    break;
            }
        }

        private static void SpacesClear(ValidateTexBox textBox)
        {
            string Answer = textBox.Text;
            Answer = System.Text.RegularExpressions.Regex.Replace(textBox.Text, @"\s+", " ");

            if (Answer.Length <= 0)
            {
                return;
            }
            if (Answer[0] == ' ')
            {
                Answer = Answer.Remove(0, 1);
            }
            if (Answer.Length >= 1)
            {
                if (Answer[Answer.Length - 1] == ' ')
                {
                    Answer = Answer.Remove(Answer.Length - 1);
                }
            }
            textBox.Text = Answer;
        }
        public static void ValidateBuilt_In(ValidateTexBox textBox)
        {
            if (textBox.ArrBuilt_In == null)
            {
                return;
            }
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
                        textBox.ValidateResult = ValidateSurname(textBox);
                        break;
                    case Built_In.Name:
                        textBox.ValidateResult = ValidateName(textBox);
                        break;
                    case Built_In.Patronymic:
                        textBox.ValidateResult = ValidatePatronymic(textBox);
                        break;
                    case Built_In.Phone:
                        textBox.ValidateResult = ValidatePhone(textBox);
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
            if (textBox.ArrCustom == null)
            {
                return;
            }
            foreach (ValidateTexBox.Custom item in textBox.ArrCustom)
            {
          
                bool Result = true;
                string text = textBox.Text;
                string parent = item.Regex;
                Regex reg = new Regex(parent);
                Result = reg.IsMatch(text);
                if (textBox.ErrorProvider != null)
                {
                    string Error = "Не соответствует типу!";
                    if (!Result)
                    {
                        textBox.ErrorProvider.SetError(textBox, item.Error);
                    }
                    else
                    {
                        textBox.ErrorProvider.Clear();
                    }

                }
                if (!textBox.ValidateResult)
                {
                    break;
                }
            }
        }
        
        public static bool ValidateLogin(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^(?=.*[a-z]).{6,}$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                string Error = "Не соответствует типу!";
                if (!Result)
                {
                    if (!new Regex(@"^.{6,}$").IsMatch(text))
                    {
                        Error += "\n-не менее 6 символов";
                    }
                    if (!new Regex(@"^(?=.*[a-z]).{1,}$").IsMatch(text))
                    {
                        Error += "\n-не менее одной буквы";
                    }
                    

                    textBox.ErrorProvider.SetError(textBox, Error);
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
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[_!?+=-]).{8,}$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                string Error = "Не соответствует типу!";
                if (!Result)
                {
                    if (!new Regex(@"^.{8,}$").IsMatch(text)) 
                    {
                        Error += "\n-не менее 8 символов";
                    }
                    if (!new Regex(@"^(?=.*[\d]).{1,}$").IsMatch(text))
                    {
                        Error += "\n-не менее одной цифры";
                    }
                    if (!new Regex(@"^(?=.*[A-Z]).{1,}$").IsMatch(text))
                    {
                        Error += "\n-не менее одной заглавной буквы";
                    }
                    if (!new Regex(@"^(?=.*[a-z]).{1,}$").IsMatch(text))
                    {
                        Error += "\n-не менее одного строчной буквы";
                    }
                    if (!new Regex(@"^(?=.*[_!?+=-]).{1,}$").IsMatch(text))
                    {
                        Error += "\n-не менее одного специального символа: _, -, !, ?, +, =";
                    }

                    textBox.ErrorProvider.SetError(textBox, Error);
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
                    textBox.ErrorProvider.SetError(textBox, "Не соответствует типу xx@xx.xx");
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }

        public static bool ValidateSurname(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^([a-zA-ZА-Яа-я]{4,30})$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                string Error = "Не соответствует типу!";
                if (!Result)
                {
                    if (!new Regex(@"^.{4,}$").IsMatch(text))
                    {
                        Error += "\n-не менее 4 символов";
                    }
                    if (!new Regex(@"^(?=.*[a-zA-ZА-Яа-я])$").IsMatch(text))
                    {
                        Error += "\n-разрешены только буквы";
                    }
                

                    textBox.ErrorProvider.SetError(textBox, Error);
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }

        public static bool ValidateName(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^([a-zA-ZА-Яа-я]{2,30})+$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                string Error = "Не соответствует типу!";
                if (!Result)
                {
                    if (!new Regex(@"^.{2,}$").IsMatch(text))
                    {
                        Error += "\n-не менее 2 символов";
                    }
                    if (!new Regex(@"^(?=.*[a-zA-ZА-Яа-я])$").IsMatch(text))
                    {
                        Error += "\n-разрешены только буквы";
                    }


                    textBox.ErrorProvider.SetError(textBox, Error);
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }

        public static bool ValidatePatronymic(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^([a-zA-ZА-Яа-я]{4,30})+$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                string Error = "Не соответствует типу!";
                if (!Result)
                {
                    if (!new Regex(@"^.{4,}$").IsMatch(text))
                    {
                        Error += "\n-не менее 4 символов";
                    }
                    if (!new Regex(@"^(?=.*[a-zA-ZА-Яа-я])$").IsMatch(text))
                    {
                        Error += "\n-разрешены только буквы";
                    }


                    textBox.ErrorProvider.SetError(textBox, Error);
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }
        public static bool ValidatePhone(ValidateTexBox textBox)
        {
            bool Result = true;
            string text = textBox.Text;
            string parent = @"^(?:\+7|8)[\d]{10,10}$";
            Regex reg = new Regex(parent);
            Result = reg.IsMatch(text);
            if (textBox.ErrorProvider != null)
            {
                if (!Result)
                {
                    textBox.ErrorProvider.SetError(textBox, "Не соответствует типу +7ХХХХХХХХХХ или 8ХХХХХХХХХХ");
                }
                else
                {
                    textBox.ErrorProvider.Clear();
                }

            }
            return Result;
        }
    }


    public class ValidateTexBox : TextBox
    {
        public ErrorProvider ErrorProvider { get; set; }
        public TypeValidate _Validate;
        public TypeValidate Validate 
        {
            get => _Validate;
            set
            {

            
                if (value != _Validate)
                {
                    _Validate = value;
                    switch (value)
                    {
                        case TypeValidate.None:
                            this.ValidateResult = true;
                            break;
                        case TypeValidate.Built_In:
                            this.ValidateResult = false;
                            break;
                        case TypeValidate.Custom:
                            this.ValidateResult = false;
                            break;
                        case TypeValidate.Double:
                            this.ValidateResult = false;
                            break;
                    }
                }
            }
        }
        public Built_In[] ArrBuilt_In { get; set; }
        public Custom[] ArrCustom { get; set; }
        public bool ValidateResult = true;
        public Object Object { get; set; }
        public UserControl Control { get; set; }
        public YesNo Spaces { get; set; }
        public Form Form { get; set; }
        public class Custom
        {
            public string Regex { get; set; }
            public string Error { get; set; }

        }
        public enum YesNo
        {
            None,
            Yes,
            No
        }
        public ValidateTexBox()
        {
            this.Validating += ValidateTexBox_Validating;
            this.TextChanged += validateTexBox_TextChanged;
            this.ErrorProvider = new ErrorProvider();
            this.ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            
        }
        private void ValidateTexBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateData.Validate(this);
            ValidateData.Spaces(this);
        }
        private void validateTexBox_TextChanged(object sender, EventArgs e)
        {
            ValidateData.Validate(this);
        }
        public void ThisValidate()
        {
            ValidateData.Validate(this);
            ValidateData.Spaces(this);
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
