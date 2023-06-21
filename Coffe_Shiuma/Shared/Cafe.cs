using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shiuma.Shared
{
    public class Cafe
    {
        public const int DefaultSize = 30;
        public const int MinimumSize = 20;
        public const int MaximumSize = 40;
        public const int IncrementSize = 2;
        public int Id { get; set; }
        public int OrderId { get; set; }
        public CafeSpecial Special { get; set; }
        public int SpecialId { get; set; }
        public int Size { get; set; }
        public List<CafeBebida> Bebidas { get; set; }
        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }
        public decimal GetTotalPrice()
        {
            return GetBasePrice() + Bebidas.Sum(t => t.Bebida.Price);
        }
        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }

}
