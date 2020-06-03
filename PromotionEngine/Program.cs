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
