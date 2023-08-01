//using HomeworkCollection.Models;
//using HomeworkCollection.Services.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeworkCollection.Services
//{
//    internal class AccountService : IAccountService
//    {
//        public List<User> GetUsers() 
//        {
//            List<User>list = new List<User>();
//            {
//                new User { Id = 1, Email = "sh@gmail1.com", Password = "sh12345" };
//                new User { Id = 1, Email = "sh@gmail2.com", Password = "sh123456" };
//                new User { Id = 1, Email = "sh@gmail3.com", Password = "sh1234567" };
//            };
//            return list;
//        }

//        public bool Login(string username, string password)
//        {
//            var users = GetUsers();
//            foreach (var item in users)
//            {
//                if (username == item.Email && password == item.Password)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

        
//    }
//}
