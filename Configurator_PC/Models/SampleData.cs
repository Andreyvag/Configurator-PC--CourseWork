using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Configurator_PC.Models;

namespace Configurator_PC.Models
{
    public static class SampleData
    {
        public static void Initialize(AccessoriesContext context)
        {
            if (!context.Processors.Any())
            {
                context.Processors.AddRange(
                    new Processor { Name = "AMD Ryzen 5 3500X", Price = 12470, Power = 15 },
                    new Processor { Name = "Intel® Core™ i5-10400F", Price = 13990, Power = 25 },
                    new Processor { Name = "AMD Ryzen 5 3600X", Price = 18619, Power = 25 },
                    new Processor { Name = "Intel® Core™ i5-10600(F)", Price = 25280, Power = 30 },
                    new Processor { Name = "Intel® Core™ i5-10600K(F)", Price = 20810, Power = 35 },
                    new Processor { Name = "Intel® Core™ i7-10700(F)", Price = 27590, Power = 40 },
                    new Processor { Name = "AMD Ryzen 5 5600X", Price = 31400, Power = 45 },
                    new Processor { Name = "Intel® Core™ i7-10700K(F)", Price = 32900, Power = 55 },
                    new Processor { Name = "AMD Ryzen 7 3800X", Price = 32990, Power = 60 },
                    new Processor { Name = "Intel® Core™ i9-10900(F)", Price = 42270, Power = 75 },
                    new Processor { Name = "Intel® Core™ i9-10900K(F)", Price = 46553, Power = 80 },
                    new Processor { Name = "AMD Ryzen 7 5800X", Price = 45699, Power = 90 },
                    new Processor { Name = "AMD Ryzen 9 5900X", Price = 62140, Power = 95 },
                    new Processor { Name = "AMD Ryzen 9 5950X", Price = 86860, Power = 100 }
                );
                context.SaveChanges();
            }

            if (!context.VideoCards.Any())
            {
                context.VideoCards.AddRange(
                    new VideoCard { Name = "MSI GeForce RTX 3080", Price = 115400, Power = 80 },
                    new VideoCard { Name = "ASUS GeForce RTX 3080", Price = 117800, Power = 85 },
                    new VideoCard { Name = "GIGABYTE GeForce RTX 3080", Price = 116000, Power = 75 },
                    new VideoCard { Name = "MSI GeForce RTX 3090", Price = 220300, Power = 90 },
                    new VideoCard { Name = "ASUS GeForce RTX 3090", Price = 229200, Power = 100 },
                    new VideoCard { Name = "GIGABYTE GeForce RTX 3090", Price = 222100, Power = 95 },
                    new VideoCard { Name = "Palit GeForce RTX 3080", Price = 97600, Power = 80 },
                    new VideoCard { Name = "GIGABYTE GeForce RTX 3070", Price = 82300, Power = 50 },
                    new VideoCard { Name = "MSI GeForce RTX 3070", Price = 71300, Power = 55 },
                    new VideoCard { Name = "ASUS GeForce RTX 3070", Price = 73800, Power = 60 },
                    new VideoCard { Name = "Palit GeForce RTX 3090", Price = 179100, Power = 90 },
                    new VideoCard { Name = "Palit GeForce RTX 3070", Price = 75700, Power = 80 },
                    new VideoCard { Name = "GIGABYTE GeForce RTX 3060 Ti", Price = 63900, Power = 45 },
                    new VideoCard { Name = "EVGA GeForce RTX 3090", Price = 248400, Power = 100 },
                    new VideoCard { Name = "ASUS GeForce RTX 3060 Ti", Price = 69400, Power = 40 }
                );
                context.SaveChanges();
            }

            if (!context.Motherboards.Any())
            {
                context.Motherboards.AddRange(
                    new Motherboard { Name = "GIGABYTE B550M AORUS PRO-P", Price = 10500, Power = 5 },
                    new Motherboard { Name = "ASUS TUF GAMING B460M-PLUS (Wi-Fi)", Price = 10600, Power = 10 },
                    new Motherboard { Name = "GIGABYTE Z490 UD", Price = 12700, Power = 15 },
                    new Motherboard { Name = "GIGABYTE Z490 UD AC", Price = 13400, Power = 20 },
                    new Motherboard { Name = "ASUS TUF GAMING B550M-PLUS (Wi-Fi)", Price = 13500, Power = 25 },
                    new Motherboard { Name = "ASUS PRIME Z490-P", Price = 13600, Power = 30 },
                    new Motherboard { Name = "MSI MAG B550M MORTAR (Wi-Fi)", Price = 14300, Power = 35 },
                    new Motherboard { Name = "GIGABYTE X570 UD", Price = 15400, Power = 40 },
                    new Motherboard { Name = "MSI MPG Z490 GAMING EDGE (Wi-Fi)", Price = 18500, Power = 45 },
                    new Motherboard { Name = "ASUS TUF GAMING Z490-PLUS", Price = 19200, Power = 50 },
                    new Motherboard { Name = "ASUS TUF GAMING Z490-PLUS (Wi-Fi)", Price = 19300, Power = 55 },
                    new Motherboard { Name = "ASUS TUF GAMING X570-PLUS", Price = 20400, Power = 60 },
                    new Motherboard { Name = "ASUS ROG STRIX Z490-H GAMING", Price = 22200, Power = 65 },
                    new Motherboard { Name = "MSI MPG X570 GAMING PRO CARBON WIFI", Price = 22600, Power = 70 },
                    new Motherboard { Name = "ASUS ROG STRIX B550-E GAMING", Price = 23100, Power = 75 },
                    new Motherboard { Name = "MSI MPG Z490 GAMING CARBON (Wi-Fi)", Price = 24200, Power = 80 },
                    new Motherboard { Name = "ASUS ROG Strix X570-F Gaming", Price = 25000, Power = 85 },
                    new Motherboard { Name = "MSI MEG X570 UNIFY", Price = 28700, Power = 90 },
                    new Motherboard { Name = "MSI MEG Z490 UNIFY", Price = 29200, Power = 92 },
                    new Motherboard { Name = "GIGABYTE Z490 AORUS ULTRA", Price = 29700, Power = 94 },
                    new Motherboard { Name = "MSI MEG Z490 ACE", Price = 40000, Power = 96 },
                    new Motherboard { Name = "ASUS ROG MAXIMUS XII HERO (Wi-Fi)", Price = 40400, Power = 98 },
                    new Motherboard { Name = "ASUS ROG MAXIMUS XII FORMULA", Price = 46800, Power = 100 }
                );
                context.SaveChanges();
            }

            if (!context.Coolings.Any())
            {
                context.Coolings.AddRange(
                    new Cooling { Name = "HYPERPC AirCooling 130 RGB", Price = 5500, Power = 60 },
                    new Cooling { Name = "HYPERPC WaterCooling 120 RGB", Price = 7900, Power = 80 },
                    new Cooling { Name = "HYPERPC WaterCooling 240 RGB", Price = 10400, Power = 100 }
                );
                context.SaveChanges();
            }

            if (!context.RAMs.Any())
            {
                context.RAMs.AddRange(
                    new RAM { Name = "8GB HyperX FURY RGB DDR4-2666", Price = 3440, Power = 10 },
                    new RAM { Name = "8GB HyperX Predator RGB DDR4-3200", Price = 4140, Power = 20 },
                    new RAM { Name = "8GB Corsair Vengeance RGB PRO DDR4-3200", Price = 4440, Power = 30 },
                    new RAM { Name = "16GB Corsair Vengeance RGB PRO DDR4-3200", Price = 7140, Power = 40 },
                    new RAM { Name = "8GB Corsair Dominator Platinum RGB DDR4-3600", Price = 7240, Power = 50 },
                    new RAM { Name = "16GB HyperX Predator RGB DDR4-3200", Price = 7940, Power = 60 },
                    new RAM { Name = "8GB G.Skill Trident Z RGB DDR4-4266", Price = 8640, Power = 70 },
                    new RAM { Name = "32GB HyperX Fury DDR4-3200", Price = 13540, Power = 80 },
                    new RAM { Name = "32GB HyperX Predator RGB DDR4-3200", Price = 15140, Power = 90 },
                    new RAM { Name = "16GB Corsair Dominator Platinum RGB DDR4-3600", Price = 17840, Power = 95 },
                    new RAM { Name = "8GB G.Skill Trident Z RGB DDR4-4600", Price = 18040, Power = 100 }
                );
                context.SaveChanges();
            }

            if (!context.SSDs.Any())
            {
                context.SSDs.AddRange(
                    new SSD { Name = "256GB HYPERPC M.2", Price = 3900, Power = 5 },
                    new SSD { Name = "250GB Kingston A2000", Price = 4000, Power = 10 },
                    new SSD { Name = "250GB Samsung 970 EVO Plus", Price = 4000, Power = 15 },
                    new SSD { Name = "256GB Kingston KC600", Price = 4400, Power = 20 },
                    new SSD { Name = "250GB Kingston KC2500", Price = 5700, Power = 25 },
                    new SSD { Name = "512GB HYPERPC M.2", Price = 6500, Power = 30 },
                    new SSD { Name = "500GB Kingston A2000", Price = 6700, Power = 35 },
                    new SSD { Name = "512GB Kingston KC600", Price = 6700, Power = 40 },
                    new SSD { Name = "500GB Samsung 970 EVO Plus", Price = 9800, Power = 45 },
                    new SSD { Name = "1TB Kingston A2000", Price = 12100, Power = 50 },
                    new SSD { Name = "1024GB HYPERPC M.2", Price = 12300, Power = 55 },
                    new SSD { Name = "1024GB Kingston KC600", Price = 12800, Power = 60 },
                    new SSD { Name = "512GB Samsung 970 PRO", Price = 14400, Power = 65 },
                    new SSD { Name = "1TB Kingston KC2500", Price = 18400, Power = 70 },
                    new SSD { Name = "1TB Samsung 970 EVO Plus", Price = 20400, Power = 75 },
                    new SSD { Name = "2048GB Kingston KC600", Price = 23100, Power = 80 },
                    new SSD { Name = "1TB Samsung 970 PRO", Price = 27200, Power = 85 },
                    new SSD { Name = "2TB HYPERPC PRO M.2", Price = 35600, Power = 90 },
                    new SSD { Name = "2TB Kingston KC2500", Price = 36500, Power = 95 },
                    new SSD { Name = "2TB Samsung 970 EVO Plus", Price = 38800, Power = 100 },
                    new SSD { Name = "-", Price = 0, Power = 0 }
                );
                context.SaveChanges();
            }

            if (!context.HardDrives.Any())
            {
                context.HardDrives.AddRange(
                    new HardDrive { Name = "1TB Seagate", Price = 3600, Power = 10 },
                    new HardDrive { Name = "2TB Seagate", Price = 5300, Power = 20 },
                    new HardDrive { Name = "3TB Seagate", Price = 8600, Power = 30 },
                    new HardDrive { Name = "4TB Seagate", Price = 9200, Power = 40 },
                    new HardDrive { Name = "6TB Seagate", Price = 15200, Power = 50 },
                    new HardDrive { Name = "8TB Seagate", Price = 19900, Power = 60 },
                    new HardDrive { Name = "10TB Seagate", Price = 31200, Power = 70 },
                    new HardDrive { Name = "12TB Seagate", Price = 34700, Power = 80 },
                    new HardDrive { Name = "16TB Seagate", Price = 43000, Power = 90 },
                    new HardDrive { Name = "18TB Seagate", Price = 49800, Power = 100 },
                    new HardDrive { Name = "-", Price = 0, Power = 0 }
                );
                context.SaveChanges();
            }

            if (!context.PowerSupplies.Any())
            {
                context.PowerSupplies.AddRange(
                    new PowerSupply { Name = "Cooler Master MasterWatt Lite 700W", Price = 4590, Power = 20 },
                    new PowerSupply { Name = "Cooler Master V750 750W", Price = 11090, Power = 40 },
                    new PowerSupply { Name = "Super Flower Leadex Silver 850W", Price = 11490, Power = 60 },
                    new PowerSupply { Name = "Cooler Master V850 V2 850W", Price = 14190, Power = 80 },
                    new PowerSupply { Name = "Super Flower Leadex Platinum 1000W", Price = 19190, Power = 90 },
                    new PowerSupply { Name = "Super Flower Leadex Titanium 1000W", Price = 26490, Power = 100 }
                );
                context.SaveChanges();
            }

            if (!context.SoundCards.Any())
            {
                context.SoundCards.AddRange(
                    new SoundCard { Name = "ASUS Xonar AE", Price = 4500, Power = 15 },
                    new SoundCard { Name = "Creative Sound Blaster Z", Price = 9100, Power = 35 },
                    new SoundCard { Name = "Creative Sound BlasterX AE-5", Price = 14600, Power = 50 },
                    new SoundCard { Name = "ASUS Strix Raid Pro", Price = 15000, Power = 60 },
                    new SoundCard { Name = "Creative Sound BlasterX G6", Price = 16200, Power = 70 },
                    new SoundCard { Name = "ASUS Strix Raid DLX", Price = 18400, Power = 75 },
                    new SoundCard { Name = "ASUS Xonar Essence STX II 7.1", Price = 27400, Power = 90 },
                    new SoundCard { Name = "Creative Sound Blaster X7", Price = 37700, Power = 100 },
                    new SoundCard { Name = "-", Price = 0, Power = 0 }
                );
                context.SaveChanges();
            }

            if (!context.NetworkAdapters.Any())
            {
                context.NetworkAdapters.AddRange(
                    new NetworkAdapter { Name = "Беспроводной Wi-Fi 300Mbps 2.4GHz", Price = 1000, Power = 25 },
                    new NetworkAdapter { Name = "Беспроводной Wi-Fi 867Mbps 2.4/5GHz + Bluetooth 4.2", Price = 2500, Power = 50 },
                    new NetworkAdapter { Name = "Беспроводной Wi-Fi 867Mbps 2.4/5GHz", Price = 2900, Power = 75 },
                    new NetworkAdapter { Name = "Беспроводной Wi-Fi 2167Mbps 2.4/5GHz", Price = 8400, Power = 100 },
                    new NetworkAdapter { Name = "-", Price = 0, Power = 0 }
                );
                context.SaveChanges();
            }

            if (!context.Configurators.Any())
            {
                context.Configurators.AddRange(
                    new Configurator
                    {
                        Name = "Budget version",
                        ProcessorId = 1,
                        VideoCardId = 1,
                        MotherboardId = 1,
                        CoolingId = 1,
                        RAMId = 1,
                        SSDId = 1,
                        HardDriveId = 1,
                        PowerSupplyId = 1,
                        SoundCardId = 1,
                        NetworkAdapterId = 1
                    },
                    new Configurator
                    {
                        Name = "Medium version",
                        ProcessorId = 7,
                        VideoCardId = 8,
                        MotherboardId = 11,
                        CoolingId = 2,
                        RAMId = 4,
                        SSDId = 13,
                        HardDriveId = 6,
                        PowerSupplyId = 3,
                        SoundCardId = 4,
                        NetworkAdapterId = 2
                    },
                    new Configurator
                    {
                        Name = "Top version",
                        ProcessorId = 14,
                        VideoCardId = 14,
                        MotherboardId = 23,
                        CoolingId = 3,
                        RAMId = 9,
                        SSDId = 20,
                        HardDriveId = 10,
                        PowerSupplyId = 6,
                        SoundCardId = 8,
                        NetworkAdapterId = 4
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
