using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoTest
{
    class User
    {

        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        private static User user;

        private User()
        {

        }

        public static User GetInstance()
        {
            if (user == null)
            {
                user = new User();
            }
            return user;
        }
    }
}
