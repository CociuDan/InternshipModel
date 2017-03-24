using GeekStore.Model;
using GeekStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GeekStore.Repository.Implimentation
{
    public class FileStorage<T> : IRepository<T>
    {
        public void DeleteProductsByCriteria(Func<T, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetProducts()
        {
            List<T> products = new List<T>();
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load($"{typeof(T).ToString().Split('.').Last()}s.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamReader reader = new StreamReader($"{typeof(T).ToString().Split('.').Last()}s.xml"))
            {
                int i = 0;
                while(reader.ReadLine() != null)
                {
                        products.Add((T)serializer.Deserialize(reader));
                }
            }
            return products;
        }

        public IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(T product)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(product.GetType());
            if (!File.Exists($"{product.GetType().ToString().Split('.').Last()}s.xml"))
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    FileStream fs = File.Create($"{product.GetType().ToString().Split('.').Last()}s.xml");
                    fs.Close();
                    serializer.Serialize(stream, product);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save($"{product.GetType().ToString().Split('.').Last()}s.xml");
                    stream.Close();
                }
            }
            else
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, product);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    foreach (XmlNode node in xmlDocument)
                    {
                        if (node.NodeType == XmlNodeType.XmlDeclaration)
                        {
                            xmlDocument.RemoveChild(node);
                        }
                    }
                    File.AppendAllText($"{product.GetType().ToString().Split('.').Last()}s.xml", Environment.NewLine + xmlDocument.InnerXml);
                    stream.Close();
                }
            }
        }
    }
}
