using System;

namespace DZ_CSharp_11._07
{
    public class WebSite
    {
        public string   name;
        public string   urlName;
        public string   description;
        public string   ip;


        public WebSite()
        {
            //name = "mystat";
            //urlName = "https://mystat.itstep.org/ua/main/homework/page/index";
            //description = " ";
            //ip = "12.1.13.13.13.13";
        }

        public WebSite(string name , string urlName , string description , string ip)
        {
            this.name = name;
            this.urlName = urlName;
            this.description = description;
            this.ip = ip;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Виведення інформації про веб сайт:\n Назва - {name},\n Url адрис{urlName},\n Опис{description},\n IР Адрес {ip}.");
        }

        public void FillInfo()
        {
            Console.WriteLine("Додання запису про веб сайт:");
            WebSite inst = new WebSite();
            inst.name = EnterString("Введіть назву сайта");
            inst.urlName = EnterString("Введіть Url назву ");
            inst.description = EnterString("Введіть опис сайту");
            inst.ip = EnterString("Введіть Ip адресу сайту");

        }

        public static string EnterString(string prompt)
        {
            Console.Write($"\t{prompt}: ");
            string str = Console.ReadLine();
            str = str.Trim();//Видалення пробілів зпочатку та кінця
            return str;
        }

    }
}
