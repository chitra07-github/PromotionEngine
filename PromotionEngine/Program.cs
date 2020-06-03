using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class SKU
    {
        public char SKUId { get; set; }
        public decimal SKUPrice { get; set; }
        public SKU(char SKUId)
        {
            this.SKUId = SKUId;
            switch (SKUId)
            {
                case 'A':
                    this.SKUPrice = 50;

                    break;
                case 'B':
                    this.SKUPrice = 30;
                    break;
                case 'C':
                    this.SKUPrice = 20;

                    break;
                case 'D':
                    this.SKUPrice = 15;
                    break;
            }
        }

    }
}
