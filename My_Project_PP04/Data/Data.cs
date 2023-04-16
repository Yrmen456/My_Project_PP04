using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_PP04.Data
{
    class Data
    {
    }
    public enum Role
    {
        Admin =1,
        Client =2,
    }

    public class Users : Gender
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DataOfBirth { get; set; }
        public int GenderCode { get; set; }
        public Role Roll { get; set; }
        
    }

    public class Genders
    {
        public List<Gender> genders { get; set; }
}
    public class Gender 
    {
        public char Code { get; set; }
        public string GenderName { get; set; }
    }
}
