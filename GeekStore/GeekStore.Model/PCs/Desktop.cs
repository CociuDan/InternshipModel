﻿using System;
using GeekStore.Model.Components.CPUs;
using GeekStore.Model.Components.Disks;
using GeekStore.Model.Components.GPUs;
using GeekStore.Model.Components.Motherboards;
using GeekStore.Model.Components.PowerUnits;
using GeekStore.Model.Components.RAMs;
using GeekStore.Model.Components;
using GeekStore.Model.Peripherals;

namespace GeekStore.Model.PCs
{
    public class Desktop : IComputer
    {
        private DesktopCPU _cpu;
        private DesktopHDD _disk;
        private DesktopGPU _gpu;
        private DesktopRAM _ram;
        private DesktopMotherboard _motherboard;
        private PSU _psu;

        public Desktop(Cooler cooler, DesktopCPU cpu, DesktopHDD drive, DesktopGPU gpu, DesktopMotherboard motherboard, PSU psu, DesktopRAM ram)
        {
            try
            {
                if (cooler == null) throw new ArgumentNullException("cooler");
                if (cpu == null) throw new ArgumentNullException("cpu");
                if (drive == null) throw new ArgumentNullException("drive");
                if (gpu == null) throw new ArgumentNullException("gpu");
                if (motherboard == null) throw new ArgumentNullException("motherboard");
                if (psu == null) throw new ArgumentNullException("psu");
                if (ram == null) throw new ArgumentNullException("ram");
                Cooler = cooler;
                _cpu = cpu;
                _disk = drive;
                _gpu = gpu;
                _motherboard = motherboard;
                _psu = psu;
                _ram = ram;
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

        public Case Case { get; set; }
        public Cooler Cooler { get; set; }
        public CPU CPU { get { return _cpu; } set { _cpu = (DesktopCPU)value; } }
        public Monitor Display { get; set; }
        public Disk Drive { get { return _disk; } set { _disk = (DesktopHDD)value; } }
        public GPU GPU { get { return _gpu; } set { _gpu = (DesktopGPU)value; } }
        public Headphones Headphones { get; set; }
        public Keyboard Keyboard { get; set; }
        public Motherboard Motherboard { get; set; }
        public Mouse Mouse { get; set; }
        public double Price { get { return CalculatePCPrice(); } }
        public PowerUnit PowerUnit { get; set; }
        public RAM RAM { get { return _ram; } set { _ram = (DesktopRAM)value; } }
        public Speakers Speakers { get; set; }

        public double CalculatePCPrice()
        {
            double price = Cooler.Price + _cpu.Price + _disk.Price + _gpu.Price + _motherboard.Price + _psu.Price + _ram.Price;
            if (Case != null)
            {
                price += Case.Price;
            }
            if (Display != null)
            {
                price += Display.Price;
            }
            if (Headphones != null)
            {
                price += Headphones.Price;
            }
            if (Keyboard != null)
            {
                price += Keyboard.Price;
            }
            if (Mouse != null)
            {
                price += Mouse.Price;
            }
            return price;
        }
    }
}
