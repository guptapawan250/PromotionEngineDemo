using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    public class Product 
    {

        public string Id { get; set; }
        public decimal Price { get; set; }
        public int? Count { get; set; }

        public Product(string id, int? count)
        {
            this.Id = id;
            this.Count = count;
            switch (Id)
            {
                case "A":
                    this.Price = 50m;
                    this.Count = count;
                    break;
                case "B":
                    this.Price = 30m;
                    this.Count = count;
                    break;
                case "C":
                    this.Price = 20m;
                    this.Count = count;
                    break;
                case "D":
                    this.Price = 15m;
                    this.Count = count;
                    break;
            }
        }
    }
}
