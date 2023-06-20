﻿namespace Coffe_Shiuma.Shared
{
    public class CafeSpecial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
