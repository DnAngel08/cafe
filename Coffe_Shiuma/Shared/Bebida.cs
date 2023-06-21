using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shiuma.Shared
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string GetFormattedPrice() => Price.ToString("0.00");
    }

}
