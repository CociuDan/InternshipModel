using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Headphones : IItem
    {
        public enum HeadphonesType { InEar, OnEar, OverEar}
        private int _impendance;
        private readonly string _manufacturer;
        private readonly int _maxVolume;
        private readonly string _model;
        private string _type;

        public Headphones(int impendance, string manufacturer, int maxVolume, string model, HeadphonesType type)
        {
            try
            {
                if (impendance <= 0)
                    throw new ArgumentException("Headphones Impendance cannot be less or equal to 0. Entered value: " + impendance.ToString());

                if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                    throw new ArgumentNullException(manufacturer);

                if (maxVolume <= 0)
                    throw new ArgumentException("Speakers Max Volume cannot be less or equal than 0 Db. Entered value: " + maxVolume.ToString());

                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentNullException(model);

                _impendance = impendance;
                _manufacturer = manufacturer;
                _maxVolume = maxVolume;
                _model = model;
                _type = type.ToString();
            }
            catch (ArgumentNullException exception)
            {
                throw exception;
            }
            catch (ArgumentException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tType: {Type}");
                sb.AppendLine($"\tImpendance: {Impendance}Ω");
                return sb.ToString();
            }
        }

        public int Impendance { get { return _impendance; } }
        public string Manufacturer { get { return _manufacturer; } }
        public int MaxVolume { get { return _maxVolume; } }
        public string Model { get { return _model; } }
        public string Type { get { return _type; } }
    }
}