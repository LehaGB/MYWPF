using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateXMLFile();
            program.Print();
            Console.ReadLine();
        }
        private void CreateXMLFile()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string family = Console.ReadLine();

            Console.Write("Город: ");
            string city = Console.ReadLine();

            Console.Write("Номер телефона: ");
            long numberPhone = long.Parse(Console.ReadLine());

            XElement person = new XElement("Person",
                new XElement("ФИО",
                    new XElement("Имя", name,
                    new XElement("Фамилия", family)),
                new XElement("Город",
                    new XElement("Город", city)),
                new XElement("MobilePhone",
                    new XElement("Phjone", numberPhone))
                ));
            person.Save("person.xml");
            Console.WriteLine("\nДанные контакта сохранены в файл worker.xml");
            Console.WriteLine("\nНажмите Enter для вывода файла на экран");
            Console.ReadKey();
        }
        private void Print()
        {
            string xml = File.ReadAllText("person.xml");

            var col = XDocument.Parse(xml)
                .Descendants("person")
                .ToList();
            foreach (var item in col)
            {
                Console.WriteLine($"\n\n{item}");
            }

        }
    }
}
