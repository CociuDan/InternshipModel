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
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(T product)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(product.GetType());
            using (MemoryStream stream = new MemoryStream())
            {                
                serializer.Serialize(stream, product);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save($"{product.GetType()}.xml");
                stream.Close();
            }
        }

        //public void DeleteProductByID(int productID)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetProducts()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetProductsByCriteria(Func<T, bool> criteria)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SaveProduct(T product)
        //{
        //    if (product == null) { return; }

        //    try
        //    {
        //        XmlDocument xmlDocument = new XmlDocument();
        //        XmlSerializer serializer = new XmlSerializer(product.GetType());
        //        using (MemoryStream stream = new MemoryStream())
        //        {
        //            serializer.Serialize(stream, product);
        //            stream.Position = 0;
        //            xmlDocument.Load(stream);
        //            xmlDocument.Save($"{product.GetType()}s.xml");
        //            stream.Close();
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Saving Failed.");
        //        Console.WriteLine($"Error message: {ex.Message}");
        //    }
        //}

    }
}
