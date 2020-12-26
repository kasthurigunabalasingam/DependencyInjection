using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIAsp.Models
{
    public interface IUserRepo
    {
        User GetUser (int Id);

    }
}
