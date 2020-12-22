using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnHelperMethods.Models
{
    public class UserRepository
    {
        public static List<User> DataSource = new List<User>();
        public void AddUser(User item)
        {
            DataSource.Add(item);
        }
        public User GetUser(string email)
        {
            return DataSource.SingleOrDefault(u => u.Email == email);
        }
        public List<User> GetUsers()
        {
            return DataSource;
        }
        public User Validate(string uname,string pwd)
        {
            return DataSource.SingleOrDefault(User => User.Uname == uname && User.Pwd == pwd);
        }
    }
}
