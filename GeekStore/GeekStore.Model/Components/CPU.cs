using System;
using System.Text;

namespace GeekStore.Model.Components
{
    public class CPU : IItem
    {
        public enum CPUCores { SingCore = 1, DualCore = 2, TripleCore = 3, QuadCore = 4, HexaCore = 6, OctaCore = 8, DecaCore = 10 }
        public enum CPUManufacturer { Intel, AMD }

        public CPU(double baseFrequency, double boostFrequency, CPUCores cores, CPUManufacturer manufacturer, string model, string socket, int tdp, int threads)
        {

            if (baseFrequency <= 0)
                throw new ArgumentException($"CPU Base Frequency cannot be less than 0. Entered value: {baseFrequency}");

            if (boostFrequency < baseFrequency)
                throw new ArgumentException($"CPU Boost Frequency cannot be less than Base Frequency. Entered value: {boostFrequency}");

            if (string.IsNullOrEmpty(model.Trim()))
                throw new ArgumentNullException(nameof(model));

            if (string.IsNullOrEmpty(socket.Trim()))
                throw new ArgumentNullException(nameof(socket));

            if (tdp <= 0)
                throw new ArgumentException($"TDP cannot be less or equal to 0. Entered value: {tdp}W");

            if (threads != (int)cores && threads != ((int)cores * 2))
                throw new ArgumentException($"Number of Threads have to be equal or double of number of cores. Entered value: {threads}. Number of cores entered: {cores}");

            BaseFrequency = baseFrequency;
            BoostFrequency = boostFrequency;
            Cores = cores;
            Manufacturer = manufacturer.ToString();
            Model = model;
            Socket = socket;
            TDP = tdp;
            Threads = threads;

        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCores: {Cores}");
                sb.AppendLine($"\tThreads: {Threads}");
                sb.AppendLine($"\tBaseClock: {BaseFrequency}Ghz");
                sb.AppendLine($"\tBoostClock: {BoostFrequency}Ghz");
                sb.AppendLine($"\tSocket: {Socket}");
                sb.AppendLine($"\tTDP: {TDP}W");
                return sb.ToString();
            }
        }
        public double BaseFrequency { get; }
        public double BoostFrequency { get; }
        public CPUCores Cores { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Socket { get; }
        public int TDP { get; }
        public int Threads { get; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} {Cores}/{Threads} @{BaseFrequency}-{BoostFrequency} {TDP}W";
        }
    }
}