using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NoWasteFoods.Models;

namespace NoWasteFoods.ViewModels
{
    public class FoodStorageViewModel
    {
        public Categories Category { get; set; }
        public List<Items> ItemList { get; set; }
    }
}