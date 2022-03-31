using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_10.Models
{
  
    public class model
    {
       
        private static List<User> alluser = new List<User>() { new User()
        {
            ID = 1,
            Name="Gaurav",
            dob="21/01/2001",
            Address="Ahmedabad",
        }

        };
      
        public static IEnumerable<User> AllUser
        {
            get { return alluser; }
        }
       
        public void add(User user)
        {
            alluser.Add(user);
        }
     
         public User Details(int id)
         {
            return alluser.FirstOrDefault(r => r.ID == id);
        }
       
        public  void Delete(int id)
        {
            var u = Get(id);
            alluser.Remove(u);
        }
        
        public void Edit(User user)
        {

            var existing = Get(user.ID);
            if(existing != null)
            {
                existing.Name = user.Name;
                existing.dob = user.dob;
                existing.Address = user.Address;
            }

        }
       
        public User Get(int id)
        {
            return alluser.FirstOrDefault(r => r.ID == id);
        }

    }
   
}