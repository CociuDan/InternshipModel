using GeekStore.Domain.Infrastucture;
using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Domain.Components
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
    }
}