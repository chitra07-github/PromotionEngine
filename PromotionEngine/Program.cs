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
            List<SKU> skus = new List<SKU>();
            Console.WriteLine("Enter the total number of order lines");
            int total = Convert.ToInt32(Console.ReadLine());
            decimal totalCost = 0;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter the type of SKU: A,B,C or D");
                char type = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the quantity for SKU: " + type);
                int skucount = Convert.ToInt32(Console.ReadLine());
                SKU sku = new SKU(type, skucount);
                skus.Add(sku);
                totalCost = GetTotalPrice(skus);
            }
            Console.WriteLine("Total Order Cost is " + totalCost.ToString());
            Console.ReadLine();

        }
        private static decimal GetTotalPrice(List<SKU> skudetails)
        {
            decimal skuAPrice = 50;
            decimal skuBPrice = 30;
            decimal skuCPrice = 20;
            decimal skuDPrice = 15;
            decimal orderPriceA = 0;
            decimal orderPriceB = 0;
            decimal orderPriceC = 0;
            decimal orderPriceD = 0;

            foreach (SKU sku in skudetails)
            {
                if (sku.SKUId == 'A')
                {
                    orderPriceA = (sku.SKUCount / 3) * 130 + (sku.SKUCount % 3 * skuAPrice);
                }
              
            }

            return orderPriceA + orderPriceB + orderPriceC + orderPriceD;

        }
    }
}
    public class SKU
    {
        public char SKUId { get; set; }
        public int SKUCount { get; set; }

        public decimal SKUPrice { get; set; }
        public SKU(char SKUId, int SKUcount)
        {
            this.SKUId = SKUId;
            this.SKUCount = SKUcount;
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
