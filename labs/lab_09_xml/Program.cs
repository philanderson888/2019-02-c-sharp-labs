using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// USE XML
using System.Xml.Linq;
// LOAD XML
using System.Xml;

namespace lab_09_xml
{
    class Program
    {
        static void Main(string[] args)
        {

            // To use use XML must add the following
            //   using System.Xml.Linq;

            Console.WriteLine("\nMost Basic XML element\n");
            var xml01 = new XElement("test", 1);  // test=name of field and value of data is 1
            Console.WriteLine(xml01);

            Console.WriteLine("\nNow add sub-element\n");
            var xml02 = new XElement("RootElement",
                new XElement("SubElement",100));
            Console.WriteLine(xml02);


            Console.WriteLine("\nNow add multiple sub-elements\n");
            var xml03 = new XElement("RootElement",
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xml03);


            Console.WriteLine("\nNow add attributes\n");
            var xml04 = new XElement("RootElement",
                new XElement("SubElement", 
                      new XAttribute("Height",500),
                100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100)
                );
            Console.WriteLine(xml04);

            Console.WriteLine("\nNow add attributes\n");
            var xml05 = new XElement("RootElement",
                new XElement("SubElement",
                      new XAttribute("Height", 500),
                100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100)
                );
            Console.WriteLine(xml05);


            Console.WriteLine("\nNow save to a document\n");
            var xml06 = new XElement("RootElement",
                new XElement("SubElement",
                      new XAttribute("Height", 500),
                100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100)
                );
            Console.WriteLine(xml06);
            // xDocument : save this to file
            var doc06 = new XDocument(XElement.Parse(xml06.ToString()));
            doc06.Save("Xml06.xml");

            Console.WriteLine("\nNow load back the same data\n");
            var doc07 = new XmlDocument();
            doc07.Load("Xml06.xml");
            Console.WriteLine(doc07.InnerXml);
            Console.WriteLine(XDocument.Parse(doc07.InnerXml));
            var doc08 = XDocument.Load("Xml06.xml");
            Console.WriteLine(doc08);
        }
    }
}
