﻿using GeekStore.Domain.Model.Components;

namespace GeekStore.Domain.Model.PCs
{
    public interface IComputer
    {
        CPU CPU { get; }
        Disk Disk { get; }
        GPU GPU { get; }
        Motherboard Motherboard { get; }
        PowerUnit PowerUnit { get; }
        RAM RAM { get; }
    }
}