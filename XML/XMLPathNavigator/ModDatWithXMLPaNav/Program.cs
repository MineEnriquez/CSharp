using System;
using System.Xml;
using System.Xml.XPath;
namespace ModDatWithXMLPaNav
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("MySmlFile.xml");
            XPathNavigator navigator = document.CreateNavigator();

            XmlNamespaceManager manager = new XmlNamespaceManager(navigator.NameTable);
            manager.AddNamespace("bk", "http://www.contoso.com/books");

            foreach (XPathNavigator nav in navigator.Select("//bk:price", manager))
            {
                if (nav.Value == "11.99")
                {
                    nav.SetValue("12.99");
                }
            }

            Console.WriteLine(navigator.OuterXml);
        }
    }
}
