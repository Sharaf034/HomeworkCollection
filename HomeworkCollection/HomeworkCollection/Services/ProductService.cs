//using HomeworkCollection.Models;
//using HomeworkCollection.Services.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeworkCollection.Services
//{
//    internal class ProductService : IProductService
//    {
//        public List<Product> GetProducts() 
//        {
//            List<Product> list = new List<Product>();
//            {
//                list.Add(new Product { Id = 1, Name = "Snikers", Count = 5, Price = 2 });
//                list.Add(new Product { Id = 2, Name = "Mars", Count = 6, Price = 6 });
//                list.Add(new Product { Id = 3, Name = "Bounty", Count = 9, Price = 3 });
//                list.Add(new Product { Id = 4, Name = "Twix", Count = 15, Price = 4 });
//            }
//            return list;
//        }

//        public string SearchByName(string searchText)
//        {
//            var products = GetProducts();
//            foreach (var item in products)
//            {
//                if (item.Name.Contains(searchText)
//                {
//                    Console.WriteLine($"{"Name products  " +item.Name}, {"Count " +item.Count}, {"Price " + item.Price}");
//                }
//            }
//            return null;
//        }
//    }
//}
