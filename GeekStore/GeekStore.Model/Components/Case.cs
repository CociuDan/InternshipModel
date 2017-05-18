using System;

namespace GeekStore.Domain.Model.Components
{
    public class Case : Product
    {
        public enum FormFactorTypes { FullTower, MidTower, MiniTower, SFF, MicroATX, MiniITX }

        public Case() { }

        //public Case(FormFactorTypes formFactor, string manufacturer, string model)
        //{
        //    if (string.IsNullOrEmpty(manufacturer.Trim())) throw new ArgumentNullException(nameof(manufacturer));
        //    if (string.IsNullOrEmpty(model.Trim())) throw new ArgumentNullException(model);

        //    FormFactor = formFactor.ToString();
        //    Manufacturer = manufacturer;
        //    Model = model;
        //}

        public virtual string FormFactor { get; protected set; }
    }
}