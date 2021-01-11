using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
   public interface IProductDetails
    {
        List<Product> GetProducts();
        int? GetTotalPrice(List<Product> products);
    }
    public class ProductDetails : IProductDetails
    {
        LogManager log = LogManager.SingleInstance;
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                Console.WriteLine("total number of order");
                int? a = Convert.ToInt32(Console.ReadLine());
                if (a > 4)
                {
                    Console.WriteLine("total number of order should be 4 and less then 4");
                    return products;
                }
                int countOfproduct = 0;
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();
                    countOfproduct++;
                    
                    Console.WriteLine(validate(countOfproduct, type));
                    Console.WriteLine("enter the count of product A,B,C or D");
                    int? count = Int32.Parse(Console.ReadLine());
                    Product p = new Product(type, count);
                    products.Add(p);
                }
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }
            return products;
        }

        public int? GetTotalPrice(List<Product> products)
        {
            int? result=0;
            try
            {
                int? counterOfA = 0;
                int priceOfA = 50;
                int? counterOfB = 0;
                int priceOfB = 30;
                int? CounterOfC = 0;
                int priceOfC = 20;
                int? CounterOfD = 0;
                int priceOfD = 15;
                foreach (Product pr in products)
                {
                    if (pr.Id == "A" || pr.Id == "a")
                    {
                        counterOfA = pr.Count ;
                    }
                    if (pr.Id == "B" || pr.Id == "b")
                    {
                        counterOfB = pr.Count ;
                    }
                    if (pr.Id == "C" || pr.Id == "c")
                    {
                        CounterOfC = pr.Count ;
                    }
                    if (pr.Id == "D" || pr.Id == "d")
                    {
                        CounterOfD = pr.Count ;
                    }
                }
                int? totalPriceofA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
                int? totalPriceofB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
                int? totalPriceofC = (CounterOfC * priceOfC);
                int? totalPriceofD = (CounterOfD * priceOfD);
                
                if (CounterOfC == 1 && CounterOfD == 1)
                {
                    int? totalCandDFixedPrice= 30;
                    result = totalPriceofA + totalPriceofB + totalCandDFixedPrice;
                }
                else
                {
                    result = totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
                }             
            
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }

            return result;
        }

        private string validate(int count, string type)
        {
           
            string result = null;
            if(count==1)
            {
                if (type.ToLower() != "a")
                    result = "Please enter valid product as A";
            }
            else if(count==2)
            {
                if (type.ToLower() != "b")
                    result = "Please enter valid product as B";
            }
            else if(count==3)
            {
                if (type.ToLower() != "c")
                    result = "Please enter valid product as C";
            }
            else
            {
                if (type.ToLower() != "d")
                    result = "Please enter valid product as D";
            }

            return result;
        }
    }
}
