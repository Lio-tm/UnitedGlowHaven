﻿using System.Collections.Generic;
using UnitedGlowHaven.Models;

namespace UnitedGlowHaven.ViewModels
{
    public class ProductListViewModel
    {
        public string ProductSearch { get; set; }
        public List<Product> Producten { get; set; }
    }
}
