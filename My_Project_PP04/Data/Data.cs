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
        public string Adress { get; set; }
        public int IDUser { get; set; }
        public string _Street { get; set; }
        public string _House { get; set; }
        public string _Room { get; set; }
        public string _Porth { get; set; }
        public string _Floor { get; set; }
        public string Street {
            get => _Street;
            set
            {
                if (value != _Street)
                {
                    _Street = value;
                    FullAdress();
                }
            }
        }
        public string House
        {
            get => _House;
            set
            {
                if (value != _House)
                {
                    _House = value;
                    FullAdress();
                }
            }
        }
        public string Room
        {
            get => _Room;
            set
            {
                if (value != _Room)
                {
                    _Room = value;
                    FullAdress();
                }
            }
        }
        public string Porth
        {
            get => _Porth;
            set
            {
                if (value != _Porth)
                {
                    _Porth = value;
                    FullAdress();
                }
            }
        }
        public string Floor
        {
            get => _Floor;
            set
            {
                if (value != _Floor)
                {
                    _Floor = value;
                    FullAdress();
                }
            }
        }


        void FullAdress()
        {
            Adress = $"ул {Street} дом {House} кв.{Room} подезд:{Porth} этаж:{Floor}";
        }
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

    public class Baskets
    {
        public List<Bascet> Basket { get; set; }
    }

    public class Bascet : Product
    {
        public int BasketID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }

       

    }

}
