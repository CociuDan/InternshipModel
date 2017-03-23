﻿using System;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model.Components
{
    public class CPU : IItem
    {
        public enum CPUCores { SingCore = 1, DualCore = 2, TripleCore = 3, QuadCore = 4, HexaCore = 6, OctaCore = 8, DecaCore = 10 }
        public enum CPUManufacturer { Intel, AMD }

        public CPU() { }

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
            Cores = (int)cores;
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
                sb.AppendLine($"\tCores: {Cores.ToString()}");
                sb.AppendLine($"\tThreads: {Threads}");
                sb.AppendLine($"\tBaseClock: {BaseFrequency}Ghz");
                sb.AppendLine($"\tBoostClock: {BoostFrequency}Ghz");
                sb.AppendLine($"\tSocket: {Socket}");
                sb.AppendLine($"\tTDP: {TDP}W");
                return sb.ToString();
            }
        }

        public int ID { get; private set; }
        public double BaseFrequency { get; private set; }
        public double BoostFrequency { get; private set; }
        public int Cores { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string Socket { get; private set; }
        public int TDP { get; private set; }
        public int Threads { get; private set; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} {Cores}/{Threads} @{BaseFrequency}-{BoostFrequency} {TDP}W";
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "CPU")
            {
                ID = int.Parse(reader["ID"]);
                Manufacturer = reader["Manufacturer"];
                Model = reader["Model"];
                BaseFrequency = double.Parse(reader["BaseFrequency"]);
                BoostFrequency = double.Parse(reader["BoostFrequency"]);
                Cores = int.Parse(reader["Cores"]);
                Threads = int.Parse(reader["Threads"]);
                Socket = reader["Socket"];
                TDP = int.Parse(reader["TDP"]);
                reader.Read();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("ID", ID.ToString());
            writer.WriteAttributeString("Manufacturer", Manufacturer);
            writer.WriteAttributeString("Model", Model);
            writer.WriteAttributeString("BaseFrequency", BaseFrequency.ToString());
            writer.WriteAttributeString("BoostFrequency", BoostFrequency.ToString());
            writer.WriteAttributeString("Cores", Cores.ToString());
            writer.WriteAttributeString("Threads", Threads.ToString());
            writer.WriteAttributeString("Socket", Socket);
            writer.WriteAttributeString("TDP", TDP.ToString());
        }
    }
}