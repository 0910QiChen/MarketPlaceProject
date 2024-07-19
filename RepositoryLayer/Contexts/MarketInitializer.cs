﻿using System.Collections.Generic;
using System.Data.Entity;
using DomainLayer.DomainModels;

namespace RepositoryLayer.Contexts
{
    public class MarketInitializer : DropCreateDatabaseIfModelChanges<MarketContext>
    {
        protected override void Seed(MarketContext _context)
        {
            // 4 Categories, 1 main category with 5 sub-categories, 2 sub-categories with more than 5 products, other 3 sub-categories with 2 products
            // 3 other categories with 2 sub-categories each and 2 products each
            var categories = new List<Categories>
            {
                // Major Category
                new Categories { CategoryName = "Computer Components" },
                // 3 Minor Categories
                new Categories { CategoryName = "Peripherals" },
                new Categories { CategoryName = "Cooling & Power" },
                new Categories { CategoryName = "Audio" }
            };
            categories.ForEach(c => _context.Categories.Add(c));
            _context.SaveChanges();

            var subCategories = new List<SubCategories>
            {
                // 5 Sub-Categories for Major Category
                new SubCategories { SubCategoryName = "CPU", CategoryID = 1 },
                new SubCategories { SubCategoryName = "GPU", CategoryID = 1 },
                new SubCategories { SubCategoryName = "Motherboard", CategoryID = 1 },
                new SubCategories { SubCategoryName = "RAM", CategoryID = 1 },
                new SubCategories { SubCategoryName = "Storage", CategoryID = 1 },

                // 2 Sub-Categories for other Minor Categories
                new SubCategories { SubCategoryName = "Mouse", CategoryID = 2 },
                new SubCategories { SubCategoryName = "Keyboard", CategoryID = 2 },
                new SubCategories { SubCategoryName = "Power Supply", CategoryID = 3 },
                new SubCategories { SubCategoryName = "Cooling System", CategoryID = 3 },
                new SubCategories { SubCategoryName = "Headphones", CategoryID = 4 },
                new SubCategories { SubCategoryName = "Speakers", CategoryID = 4 }
            };
            subCategories.ForEach(sc => _context.SubCategories.Add(sc));
            _context.SaveChanges();

            var products = new List<Products>
            {
                // Products for CPU
                new Products { ProductName = "Intel Core i9-13900K", SubCategoryID = 1 },
                new Products { ProductName = "AMD Ryzen 9 7950X", SubCategoryID = 1 },
                new Products { ProductName = "Intel Core i7-13700K", SubCategoryID = 1 },
                new Products { ProductName = "AMD Ryzen 7 7800X", SubCategoryID = 1 },
                new Products { ProductName = "Intel Core i5-13600K", SubCategoryID = 1 },
                new Products { ProductName = "AMD Ryzen 5 7600X", SubCategoryID = 1 },
                // Products for GPU
                new Products { ProductName = "NVIDIA GeForce RTX 4090", SubCategoryID = 2 },
                new Products { ProductName = "AMD Radeon RX 7900 XTX", SubCategoryID = 2 },
                new Products { ProductName = "NVIDIA GeForce RTX 4080", SubCategoryID = 2 },
                new Products { ProductName = "AMD Radeon RX 7800 XT", SubCategoryID = 2 },
                new Products { ProductName = "NVIDIA GeForce RTX 4070 Ti", SubCategoryID = 2 },
                new Products { ProductName = "AMD Radeon RX 7700 XT", SubCategoryID = 2 },
                // Products for Motherboard
                new Products { ProductName = "ASUS ROG Strix Z790-E", SubCategoryID = 3 },
                new Products { ProductName = "MSI MEG Z790 ACE", SubCategoryID = 3 },
                new Products { ProductName = "Gigabyte Z790 AORUS Xtreme", SubCategoryID = 3 },
                new Products { ProductName = "ASRock Z790 Taichi", SubCategoryID = 3 },
                new Products { ProductName = "ASUS TUF Gaming X670E-Plus", SubCategoryID = 3 },
                new Products { ProductName = "MSI MAG X670E Tomahawk", SubCategoryID = 3 },
                // Products for RAM
                new Products { ProductName = "Corsair Vengeance LPX 16GB (2 x 8GB) DDR4-3200", SubCategoryID = 4 },
                new Products { ProductName = "G.SKILL Trident Z RGB 32GB (2 x 16GB) DDR4-3600", SubCategoryID = 4 },
                new Products { ProductName = "Kingston Fury Beast 16GB (2 x 8GB) DDR4-3200", SubCategoryID = 4 },
                new Products { ProductName = "Crucial Ballistix 32GB (2 x 16GB) DDR4-3600", SubCategoryID = 4 },
                new Products { ProductName = "Corsair Vengeance Pro 16GB (2 x 8GB) DDR4-2666", SubCategoryID = 4 },
                new Products { ProductName = "G.SKILL Ripjaws V 32GB (2 x 16GB) DDR4-3400", SubCategoryID = 4 },
                // Products for Storage
                new Products { ProductName = "Samsung 970 EVO Plus 1TB NVMe SSD", SubCategoryID = 5 },
                new Products { ProductName = "Western Digital Black SN850 1TB NVMe SSD", SubCategoryID = 5 },
                new Products { ProductName = "Crucial MX500 1TB SATA SSD", SubCategoryID = 5 },
                new Products { ProductName = "Samsung 860 EVO 1TB SATA SSD", SubCategoryID = 5 },
                new Products { ProductName = "Seagate Barracuda 2TB HDD", SubCategoryID = 5 },
                new Products { ProductName = "Western Digital Blue 2TB HDD", SubCategoryID = 5 },

                // Products for Mouse
                new Products { ProductName = "Logitech MX Master 3", SubCategoryID = 6 },
                new Products { ProductName = "Razer DeathAdder V2", SubCategoryID = 6 },
                // Products for Keyboard
                new Products { ProductName = "Corsair K95 RGB Platinum", SubCategoryID = 7 },
                new Products { ProductName = "Razer BlackWidow V3", SubCategoryID = 7 },
                // Products for Power Supply
                new Products { ProductName = "Corsair RM850x", SubCategoryID = 8 },
                new Products { ProductName = "EVGA SuperNOVA 750 G5", SubCategoryID = 8 },
                // Products for Cooling System
                new Products { ProductName = "Noctua NH-D15", SubCategoryID = 9 },
                new Products { ProductName = "Corsair H150i Elite Capellix", SubCategoryID = 9 },
                // Products for Headphones
                new Products { ProductName = "Sony WH-1000XM5", SubCategoryID = 10 },
                new Products { ProductName = "Bose QuietComfort 45", SubCategoryID = 10 },
                // Products for Speakers
                new Products { ProductName = "Klipsch R-51PM", SubCategoryID = 11 },
                new Products { ProductName = "Polk Audio RTI A1", SubCategoryID = 11 },
            };
            products.ForEach(p => _context.Products.Add(p));
            _context.SaveChanges();

            var attributes = new List<Attributes>
            {
                // Attributes for CPU
                new Attributes { AttributeName = "Core Count", SubCategoryID = 1 },
                new Attributes { AttributeName = "Base Clock Speed", SubCategoryID = 1 },
                new Attributes { AttributeName = "Cache Size", SubCategoryID = 1 },
                new Attributes { AttributeName = "TDP (Thermal Design Power)", SubCategoryID = 1 },

                // Attributes for GPU
                new Attributes { AttributeName = "VRAM", SubCategoryID = 2 },
                new Attributes { AttributeName = "Core Clock Speed", SubCategoryID = 2 },
                new Attributes { AttributeName = "CUDA Cores", SubCategoryID = 2 },
                new Attributes { AttributeName = "Ray Tracing Support", SubCategoryID = 2 },

                // Attributes for Motherboard
                new Attributes { AttributeName = "Socket Type", SubCategoryID = 3 },
                new Attributes { AttributeName = "Chipset", SubCategoryID = 3 },
                new Attributes { AttributeName = "RAM Slots", SubCategoryID = 3 },
                new Attributes { AttributeName = "PCIe Slots", SubCategoryID = 3 },

                // Attributes for RAM
                new Attributes { AttributeName = "Capacity", SubCategoryID = 4 },
                new Attributes { AttributeName = "Memory Type", SubCategoryID = 4 },
                new Attributes { AttributeName = "Speed", SubCategoryID = 4 },
                new Attributes { AttributeName = "Module Configuration", SubCategoryID = 4 },

                // Attributes for Storage
                new Attributes { AttributeName = "Capacity", SubCategoryID = 5 },
                new Attributes { AttributeName = "Interface", SubCategoryID = 5 },
                new Attributes { AttributeName = "Read Speed", SubCategoryID = 5 },
                new Attributes { AttributeName = "Write Speed", SubCategoryID = 5 },

                // Attributes for Mouse
                new Attributes { AttributeName = "Connection Type", SubCategoryID = 6 },
                new Attributes { AttributeName = "DPI", SubCategoryID = 6 },
                new Attributes { AttributeName = "Battery Type", SubCategoryID = 6 },
                new Attributes { AttributeName = "Design", SubCategoryID = 6 },

                // Attributes for Keyboard
                new Attributes { AttributeName = "Switch Type", SubCategoryID = 7 },
                new Attributes { AttributeName = "Backlighting", SubCategoryID = 7 },
                new Attributes { AttributeName = "Key Count", SubCategoryID = 7 },
                new Attributes { AttributeName = "Connection Type", SubCategoryID = 7 },

                // Attributes for Power Supply
                new Attributes { AttributeName = "Wattage", SubCategoryID = 8 },
                new Attributes { AttributeName = "Efficiency Rating", SubCategoryID = 8 },
                new Attributes { AttributeName = "Modular", SubCategoryID = 8 },
                new Attributes { AttributeName = "Fan Size", SubCategoryID = 8 },

                // Attributes for Cooling System
                new Attributes { AttributeName = "Cooling Type", SubCategoryID = 9 },
                new Attributes { AttributeName = "Radiator / Fan Size", SubCategoryID = 9 },
                new Attributes { AttributeName = "TDP Support", SubCategoryID = 9 },
                new Attributes { AttributeName = "Fan / Heatpipe Count", SubCategoryID = 9 },

                // Attributes for Headphones
                new Attributes { AttributeName = "Type", SubCategoryID = 10 },
                new Attributes { AttributeName = "Connectivity", SubCategoryID = 10 },
                new Attributes { AttributeName = "Battery Life", SubCategoryID = 10 },
                new Attributes { AttributeName = "Noise Cancellation", SubCategoryID = 10 },

                // Attributes for Speakers
                new Attributes { AttributeName = "Speaker Type", SubCategoryID = 11 },
                new Attributes { AttributeName = "Connectivity", SubCategoryID = 11 },
                new Attributes { AttributeName = "Power Output", SubCategoryID = 11 },
                new Attributes { AttributeName = "Woofer Size", SubCategoryID = 11 },
            };
            attributes.ForEach(a => _context.Attributes.Add(a));
            _context.SaveChanges();

            var details = new List<AttributeDetails>
            {
                // Details for Intel Core i9-13900K
                new AttributeDetails { AttributeID = 1, ProductID = 1, Details = "24" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 1, Details = "3.0 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 1, Details = "36 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 1, Details = "125W" }, 

                // Details for AMD Ryzen 9 7950X
                new AttributeDetails { AttributeID = 1, ProductID = 2, Details = "16" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 2, Details = "4.2 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 2, Details = "64 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 2, Details = "170W" }, 

                // Details for Intel Core i7-13700K
                new AttributeDetails { AttributeID = 1, ProductID = 3, Details = "16" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 3, Details = "3.4 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 3, Details = "30 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 3, Details = "125W" }, 

                // Details for AMD Ryzen 7 7800X
                new AttributeDetails { AttributeID = 1, ProductID = 4, Details = "8" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 4, Details = "4.7 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 4, Details = "32 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 4, Details = "105W" }, 

                // Details for Intel Core i5-13600K
                new AttributeDetails { AttributeID = 1, ProductID = 5, Details = "14" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 5, Details = "3.7 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 5, Details = "20 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 5, Details = "125W" }, 

                // Details for AMD Ryzen 5 7600X
                new AttributeDetails { AttributeID = 1, ProductID = 6, Details = "6" }, 
                new AttributeDetails { AttributeID = 2, ProductID = 6, Details = "4.7 GHz" }, 
                new AttributeDetails { AttributeID = 3, ProductID = 6, Details = "32 MB" }, 
                new AttributeDetails { AttributeID = 4, ProductID = 6, Details = "105W" }, 

                // Details for NVIDIA GeForce RTX 4090
                new AttributeDetails { AttributeID = 5, ProductID = 7, Details = "24 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 7, Details = "2.52 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 7, Details = "16384" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 7, Details = "Yes" }, 

                // Details for AMD Radeon RX 7900 XTX
                new AttributeDetails { AttributeID = 5, ProductID = 8, Details = "24 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 8, Details = "2.50 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 8, Details = "6144" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 8, Details = "Yes" }, 

                // Details for NVIDIA GeForce RTX 4080
                new AttributeDetails { AttributeID = 5, ProductID = 9, Details = "16 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 9, Details = "2.21 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 9, Details = "9728" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 9, Details = "Yes" }, 

                // Details for AMD Radeon RX 7800 XT
                new AttributeDetails { AttributeID = 5, ProductID = 10, Details = "16 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 10, Details = "2.40 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 10, Details = "5120" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 10, Details = "Yes" }, 

                // Details for NVIDIA GeForce RTX 4070 Ti
                new AttributeDetails { AttributeID = 5, ProductID = 11, Details = "12 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 11, Details = "2.61 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 11, Details = "7680" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 11, Details = "Yes" }, 

                // Details for AMD Radeon RX 7700 XT
                new AttributeDetails { AttributeID = 5, ProductID = 12, Details = "12 GB" }, 
                new AttributeDetails { AttributeID = 6, ProductID = 12, Details = "2.35 GHz" }, 
                new AttributeDetails { AttributeID = 7, ProductID = 12, Details = "5120" }, 
                new AttributeDetails { AttributeID = 8, ProductID = 12, Details = "Yes" }, 

                // Details for ASUS ROG Strix Z790-E
                new AttributeDetails { AttributeID = 9, ProductID = 13, Details = "LGA 1700" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 13, Details = "Intel Z790" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 13, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 13, Details = "3" }, 

                // Details for MSI MEG Z790 ACE
                new AttributeDetails { AttributeID = 9, ProductID = 14, Details = "LGA 1700" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 14, Details = "Intel Z790" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 14, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 14, Details = "4" }, 

                // Details for Gigabyte Z790 AORUS Xtreme
                new AttributeDetails { AttributeID = 9, ProductID = 15, Details = "LGA 1700" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 15, Details = "Intel Z790" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 15, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 15, Details = "5" }, 

                // Details for ASRock Z790 Taichi
                new AttributeDetails { AttributeID = 9, ProductID = 16, Details = "LGA 1700" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 16, Details = "Intel Z790" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 16, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 16, Details = "3" }, 

                // Details for ASUS TUF Gaming X670E-Plus
                new AttributeDetails { AttributeID = 9, ProductID = 17, Details = "Socket AM5" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 17, Details = "AMD X670E" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 17, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 17, Details = "3" }, 

                // Details for MSI MAG X670E Tomahawk
                new AttributeDetails { AttributeID = 9, ProductID = 18, Details = "Socket AM5" }, 
                new AttributeDetails { AttributeID = 10, ProductID = 18, Details = "AMD X670E" }, 
                new AttributeDetails { AttributeID = 11, ProductID = 18, Details = "4" }, 
                new AttributeDetails { AttributeID = 12, ProductID = 18, Details = "4" }, 

                // Details for Corsair Vengeance LPX 16GB (2 x 8GB) DDR4-3200
                new AttributeDetails { AttributeID = 13, ProductID = 19, Details = "16 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 19, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 19, Details = "3200 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 19, Details = "2 x 8 GB" }, 

                // Details for G.SKILL Trident Z RGB 32GB (2 x 16GB) DDR4-3600
                new AttributeDetails { AttributeID = 13, ProductID = 20, Details = "32 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 20, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 20, Details = "3600 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 20, Details = "2 x 16 GB" }, 

                // Details for Kingston Fury Beast 16GB (2 x 8GB) DDR4-3200
                new AttributeDetails { AttributeID = 13, ProductID = 21, Details = "16 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 21, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 21, Details = "3200 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 21, Details = "2 x 8 GB" }, 

                // Details for Crucial Ballistix 32GB (2 x 16GB) DDR4-3600
                new AttributeDetails { AttributeID = 13, ProductID = 22, Details = "32 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 22, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 22, Details = "3600 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 22, Details = "2 x 16 GB" }, 

                // Details for Corsair Vengeance Pro 16GB (2 x 8GB) DDR4-2666
                new AttributeDetails { AttributeID = 13, ProductID = 23, Details = "16 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 23, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 23, Details = "2666 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 23, Details = "2 x 8 GB" }, 

                // Details for G.SKILL Ripjaws V 32GB (2 x 16GB) DDR4-3400
                new AttributeDetails { AttributeID = 13, ProductID = 24, Details = "32 GB" }, 
                new AttributeDetails { AttributeID = 14, ProductID = 24, Details = "DDR4" }, 
                new AttributeDetails { AttributeID = 15, ProductID = 24, Details = "3400 MHz" }, 
                new AttributeDetails { AttributeID = 16, ProductID = 24, Details = "2 x 16 GB" }, 

                // Details for Samsung 970 EVO Plus 1TB NVMe SSD
                new AttributeDetails { AttributeID = 17, ProductID = 25, Details = "1 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 25, Details = "NVMe" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 25, Details = "3500 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 25, Details = "3300 MB/s" }, 

                // Details for Western Digital Black SN850 1TB NVMe SSD
                new AttributeDetails { AttributeID = 17, ProductID = 26, Details = "1 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 26, Details = "NVMe" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 26, Details = "7000 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 26, Details = "5300 MB/s" }, 

                // Details for Crucial MX500 1TB SATA SSD
                new AttributeDetails { AttributeID = 17, ProductID = 27, Details = "1 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 27, Details = "SATA" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 27, Details = "560 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 27, Details = "510 MB/s" }, 

                // Details for Samsung 860 EVO 1TB SATA SSD
                new AttributeDetails { AttributeID = 17, ProductID = 28, Details = "1 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 28, Details = "SATA" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 28, Details = "550 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 28, Details = "520 MB/s" }, 

                // Details for Seagate Barracuda 2TB HDD
                new AttributeDetails { AttributeID = 17, ProductID = 29, Details = "2 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 29, Details = "SATA" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 29, Details = "160 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 29, Details = "160 MB/s" }, 

                // Details for Western Digital Blue 2TB HDD
                new AttributeDetails { AttributeID = 17, ProductID = 30, Details = "2 TB" }, 
                new AttributeDetails { AttributeID = 18, ProductID = 30, Details = "SATA" }, 
                new AttributeDetails { AttributeID = 19, ProductID = 30, Details = "150 MB/s" }, 
                new AttributeDetails { AttributeID = 20, ProductID = 30, Details = "150 MB/s" }, 

                // Details for Logitech MX Master 3
                new AttributeDetails { AttributeID = 21, ProductID = 31, Details = "Wireless" }, 
                new AttributeDetails { AttributeID = 22, ProductID = 31, Details = "1600 DPI" }, 
                new AttributeDetails { AttributeID = 23, ProductID = 31, Details = "Rechargeable" }, 
                new AttributeDetails { AttributeID = 24, ProductID = 31, Details = "Ergonomic" }, 

                // Details for Razer DeathAdder V2
                new AttributeDetails { AttributeID = 21, ProductID = 32, Details = "Wired" }, 
                new AttributeDetails { AttributeID = 22, ProductID = 32, Details = "20000 DPI" }, 
                new AttributeDetails { AttributeID = 23, ProductID = 32, Details = "Cable" }, 
                new AttributeDetails { AttributeID = 24, ProductID = 32, Details = "Ergonomic" }, 

                // Details for Corsair K95 RGB Platinum
                new AttributeDetails { AttributeID = 25, ProductID = 33, Details = "Mechanical" }, 
                new AttributeDetails { AttributeID = 26, ProductID = 33, Details = "RGB" }, 
                new AttributeDetails { AttributeID = 27, ProductID = 33, Details = "104" }, 
                new AttributeDetails { AttributeID = 28, ProductID = 33, Details = "USB" }, 

                // Details for Razer BlackWidow V3
                new AttributeDetails { AttributeID = 25, ProductID = 34, Details = "Mechanical" }, 
                new AttributeDetails { AttributeID = 26, ProductID = 34, Details = "RGB" }, 
                new AttributeDetails { AttributeID = 27, ProductID = 34, Details = "104" }, 
                new AttributeDetails { AttributeID = 28, ProductID = 34, Details = "USB" }, 

                // Details for Corsair RM850x
                new AttributeDetails { AttributeID = 29, ProductID = 35, Details = "850W" }, 
                new AttributeDetails { AttributeID = 30, ProductID = 35, Details = "80+ Gold" }, 
                new AttributeDetails { AttributeID = 31, ProductID = 35, Details = "Fully Modular" }, 
                new AttributeDetails { AttributeID = 32, ProductID = 35, Details = "140mm" }, 

                // Details for EVGA SuperNOVA 750 G5
                new AttributeDetails { AttributeID = 29, ProductID = 36, Details = "750W" }, 
                new AttributeDetails { AttributeID = 30, ProductID = 36, Details = "80+ Gold" }, 
                new AttributeDetails { AttributeID = 31, ProductID = 36, Details = "Fully Modular" }, 
                new AttributeDetails { AttributeID = 32, ProductID = 36, Details = "135mm" }, 

                // Details for Noctua NH-D15
                new AttributeDetails { AttributeID = 33, ProductID = 37, Details = "Dual Tower" }, 
                new AttributeDetails { AttributeID = 34, ProductID = 37, Details = "140mm" }, 
                new AttributeDetails { AttributeID = 35, ProductID = 37, Details = "65W" }, 
                new AttributeDetails { AttributeID = 36, ProductID = 37, Details = "4 Heatpipes" }, 

                // Details for Corsair H150i Elite Capellix
                new AttributeDetails { AttributeID = 33, ProductID = 38, Details = "AIO Liquid Cooler" }, 
                new AttributeDetails { AttributeID = 34, ProductID = 38, Details = "360mm" }, 
                new AttributeDetails { AttributeID = 35, ProductID = 38, Details = "300W" }, 
                new AttributeDetails { AttributeID = 36, ProductID = 38, Details = "3 Fans" }, 

                // Details for Sony WH-1000XM5
                new AttributeDetails { AttributeID = 37, ProductID = 39, Details = "Over-Ear" }, 
                new AttributeDetails { AttributeID = 38, ProductID = 39, Details = "Wireless" }, 
                new AttributeDetails { AttributeID = 39, ProductID = 39, Details = "30 Hours" }, 
                new AttributeDetails { AttributeID = 40, ProductID = 39, Details = "Active Noise Cancellation" }, 

                // Details for Bose QuietComfort 45
                new AttributeDetails { AttributeID = 37, ProductID = 40, Details = "Over-Ear" }, 
                new AttributeDetails { AttributeID = 38, ProductID = 40, Details = "Wireless" }, 
                new AttributeDetails { AttributeID = 39, ProductID = 40, Details = "24 Hours" }, 
                new AttributeDetails { AttributeID = 40, ProductID = 40, Details = "Active Noise Cancellation" }, 

                // Details for Klipsch R-51PM
                new AttributeDetails { AttributeID = 41, ProductID = 41, Details = "Bookshelf" }, 
                new AttributeDetails { AttributeID = 42, ProductID = 41, Details = "Wireless" }, 
                new AttributeDetails { AttributeID = 43, ProductID = 41, Details = "50W" }, 
                new AttributeDetails { AttributeID = 44, ProductID = 41, Details = "Dual 5.25" }, 

                // Details for Polk Audio RTI A1
                new AttributeDetails { AttributeID = 41, ProductID = 42, Details = "Bookshelf" }, 
                new AttributeDetails { AttributeID = 42, ProductID = 42, Details = "Wired" }, 
                new AttributeDetails { AttributeID = 43, ProductID = 42, Details = "100W" }, 
                new AttributeDetails { AttributeID = 44, ProductID = 42, Details = "Dual 5.25" }, 
            };
            details.ForEach(d => _context.AttributeDetails.Add(d));
            _context.SaveChanges();
        }
    }
}