using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_PP04.Data
{
    class Data
    {
        public static UserData User;
    }

    class UserData : Users
    {
        
        public UserAddresses UserAdres { get; set; }
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
        public char GenderCode { get; set; }
        public Role Roll { get; set; }
        
    }

    public class UserAddresses 
    {
        public List<UserAdres> UserAdres { get; set; }
    }

    public class UserAdres
    {
        public int ID { get; set; }
        public int IDUser { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Room { get; set; }
        public string Porth { get; set; }
        public string Floor { get; set; }
    }

    public class Genders
    {
        public List<Gender> Gender { get; set; }
}
    public class Gender 
    {
        public char Code { get; set; }
        public string GenderName { get; set; }
    }


    public class Categories
    {
        public List<Category> Category { get; set; }
    }
    public class Category
    {
        public int ID { get; set; }
        public string CategorieName { get; set; }
        public string CategorieSCR { get; set; }
    }

    public class Products
    {
        public List<Product> Product { get; set; }
    }
    public class Product : Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SCR { get; set; }
        public int Price { get; set; }
        public int Category { get; set; }
    }
}
