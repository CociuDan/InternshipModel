using System;
using System.Text;

namespace GeekStore.Model.Peripherals
{
    public class Headphones : IItem
    {
        public enum HeadphonesType { InEar, OnEar, OverEar}

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

                Impendance = impendance;
                Manufacturer = manufacturer;
                MaxVolume = maxVolume;
                Model = model;
                Type = type.ToString();
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

        public int Impendance { get; }
        public string Manufacturer { get; }
        public int MaxVolume { get; }
        public string Model { get; }
        public string Type { get; }
    }
}