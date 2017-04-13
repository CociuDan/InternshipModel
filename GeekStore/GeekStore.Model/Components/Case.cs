using GeekStore.Domain.Model.IDGenerator;
using System;
using System.Text;

namespace GeekStore.Domain.Model.Components
{
    public class Case : IItem
    {
        public enum FormFactorTypes { FullTower, MidTower, MiniTower, SFF, MicroATX, MiniITX }

        public Case() { }

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

        public virtual string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tForm Factor: {FormFactor}");
                return sb.ToString();
            }
            protected set
            {
                Description = value;
            }
        }

        public virtual int ID { get; protected set; }
        public virtual string FormFactor { get; protected set; }
        public virtual string Manufacturer { get; protected set; }
        public virtual string Model { get; protected set; }
    }
}