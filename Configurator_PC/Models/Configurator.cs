using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Configurator_PC.Models
{
    public class Configurator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProcessorId { get; set; }
        public int VideoCardId { get; set; }
        public int MotherboardId { get; set; }
        public int CoolingId { get; set; }
        public int RAMId { get; set; }
        public int SSDId { get; set; }
        public int HardDriveId { get; set; }
        public int PowerSupplyId { get; set; }
        public int SoundCardId { get; set; }
        public int NetworkAdapterId { get; set; }
        public Processor Processor { get; set; }
        public VideoCard VideoCard { get; set; }
        public Motherboard Motherboard { get; set; }
        public Cooling Cooling { get; set; }
        public RAM RAM { get; set; }
        public SSD SSD { get; set; }
        public HardDrive HardDrive { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public SoundCard SoundCard { get; set; }
        public NetworkAdapter NetworkAdapter { get; set; }
    }
}
