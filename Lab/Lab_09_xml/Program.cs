using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Use Xml
using System.Xml.Linq;
using System.Xml;

namespace Lab_09_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMost basic Xml element\n");
            var xml01 = new XElement("test", 1); // test = name of field, 1 is value of data
            Console.WriteLine(xml01);

            Console.WriteLine("\nAdd Sub-element");
            var xml02 = new XElement("RootElement", 
                new XElement("Subelement", 100));
            Console.WriteLine(xml02);

            Console.WriteLine("\nAdd multiple Sub-element");
            var xml03 = new XElement("RootElement",
                new XElement("Subelement", 100),
                new XElement("Subelement", 100),
                new XElement("Subelement", 100));
            Console.WriteLine(xml03);

            Console.WriteLine("\nAdd a attribute to element");
            var xml04 = new XElement("RootElement",
                new XElement("Subelement", new XAttribute("height", 500), 100),
                new XElement("Subelement", 100),
                new XElement("Subelement", 100));
            Console.WriteLine(xml04);

            Console.WriteLine("\nAdd multiple attributes to element");
            var xml05 = new XElement("RootElement",
                new XElement("Subelement", new XAttribute("height", 500),100),
                new XElement("Subelement", new XAttribute("height", 500), 100),
                new XElement("Subelement", new XAttribute("height", 500), 100));
            Console.WriteLine(xml05);

            Console.WriteLine("\nSave to document");
            var xml06 = new XElement("RootElement",
                new XElement("Subelement", new XAttribute("height", 500), 100),
                new XElement("Subelement", new XAttribute("height", 500), 100),
                new XElement("Subelement", new XAttribute("height", 500), 100));
            var doc06 = new XDocument(XElement.Parse(xml06.ToString()));
            doc06.Save("Xml06.xml");

            Console.WriteLine("\nLoad new File");
            var doc07 = XDocument.Load("Xml06.xml");
            Console.WriteLine(doc07); 
            //doc07.Load("Xml06.xml");
            //Console.WriteLine(XDocument.Parse(doc07.InnerXml));
        }
    }
}
