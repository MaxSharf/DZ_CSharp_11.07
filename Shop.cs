using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_CSharp_11._07
{
    public class Shop
    {
        public string name;
        public string year;
        public string description;
        public string phoneNumber;
        public string email;

        public Shop()
        {
            name = "NIKE";
            year = "18.03.2004";
            description = "The shop of  oridginal shoes and clothing";
            phoneNumber = "+380953168794";
            email = "NIKE@gmail.com";
        }

        public Shop(string name, string year, string description, string phoneNumber, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Виведення інформації про магазин :\n Назва - {name},\n Рік випуску - {year},\n Опис - {description},\n Контактний телефон - {phoneNumber}, \n  Адрес електроної почти - {email}.");
        }

    }
}
