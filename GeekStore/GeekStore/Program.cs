using System.Collections.Generic;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components;
using GeekStore.Model;
using GeekStore.Service.Implimentation;
using GeekStore.Service.Interfaces;
using static System.Console;
using static GeekStore.Factory.CPUFactory;
using static GeekStore.Factory.DiskFactory;
using System.Xml.Linq;
using System.Xml;

namespace GeekStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> justAList = new List<Product>();
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));
            justAList.Add(new Product(1, ItemTypes.CPU, 300, 1));

            IGeekStoreService _geekStore_Service = new GeekStoreService();

            foreach (Product item in justAList)
            {
                _geekStore_Service.SaveProduct(item);
            }
            //foreach (var item in _geekStore_Service.GetProducts<Product>())
            //{
            //    WriteLine(item.ToString());
            //}







            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml("<book>" +
            //            "  <title>Oberon's Legacy</title>" +
            //            "  <price>5.95</price>" +
            //            "</book>");

            //// Create a new element node.
            //XmlNode newElem = doc.CreateNode("element", "pages", "");
            //newElem.InnerText = "290";

            //WriteLine("Add the new element to the document...");
            //XmlElement root = doc.DocumentElement;
            //root.AppendChild(newElem);

            //WriteLine("Display the modified XML document...");
            //WriteLine(doc.OuterXml);

            ReadKey();
        }
    }
}
