using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string street = Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string flatNumber = Console.ReadLine();
            Console.WriteLine("Введите мобильный телефон:");
            string moblilePhone = Console.ReadLine();
            Console.WriteLine("Введите домашний телефон:");
            string flatPhone = Console.ReadLine();

            XElement Person = new XElement("Person");
            XElement Address = new XElement("Address");
            XElement Street = new XElement("Street", street);
            XElement HouseNumber = new XElement("HouseNumber", houseNumber);
            XElement FlatNumber = new XElement("FlatNumber", flatNumber);
            XElement Phones = new XElement("Phones");
            XElement MobilePhone = new XElement("MobilePhone", moblilePhone);
            XElement FlatPhone = new XElement("FlatPhone", flatPhone);

            XAttribute Xname = new XAttribute("name", name);

            Person.Add(Address, Phones, Xname);
            Address.Add(Street, HouseNumber, FlatNumber);
            Phones.Add(MobilePhone, FlatPhone);

            Person.Save("_Person.xml");
        }
    }
}
