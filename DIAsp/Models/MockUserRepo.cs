using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIAsp.Models
{
    public class MockUserRepo : IUserRepo
    {
        private List<User> userList;
        public MockUserRepo()
        {
            userList = new List<User>()
        {
            new User() { Id = 1, Name = "Joe" },
            new User() { Id = 2, Name = "Jan" },
            new User() { Id = 3, Name = "Ann" },
        };
        }
        public User GetUser(int Id)
        {
            return this.userList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
