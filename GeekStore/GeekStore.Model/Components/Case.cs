using GeekStore.Model.Infrastucture;
using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Components
{
    public class Case : IItem
    {
        public enum FormFactorTypes { FullTower, MidTower, MiniTower, SFF, MicroATX, MiniITX }

        public Case(FormFactorTypes formFactor, string manufacturer, string model)
        {
            if (string.IsNullOrEmpty(manufacturer.Trim()))
                throw new ArgumentNullException(nameof(manufacturer));

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(model);

            FormFactor = formFactor.ToString();
            ID = IDGenerator<Case>.NextID();
            Manufacturer = manufacturer;
            Model = model;
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tForm Factor: {FormFactor}");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public string FormFactor { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Case")
            {
                ID = int.Parse(reader["ID"]);
                Manufacturer = reader["Manufacturer"];
                Model = reader["Model"];
                FormFactor = reader["FormFactor"];
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("ID", ID.ToString());
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("FormFactor", FormFactor);
        }
    }
}