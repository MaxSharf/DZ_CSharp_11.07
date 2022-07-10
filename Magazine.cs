using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_CSharp_11._07
{
    public class Magazine
    {
        public string name;
        public string year;
        public string description;
        public string phoneNumber;
        public string email;

        public Magazine()
        {
            name = "Forbes";
            year = "2000.01.01";
            description = " Про статки відомих людей";
            phoneNumber = "+380953168794";
            email = "ForbesOffichal@gmail.com";
        }

        public Magazine(string name, string year, string description, string phoneNumber , string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Виведення інформації про веб сайт:\n Назва - {name},\n Рік випуску - {year},\n Опис - {description},\n Контактний телефон - {phoneNumber}, \n  Адрес електроної почти - {email}.");
        }



    }
}
