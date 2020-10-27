using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public interface IUserRepository
    {
        ApplicationUser GetUser(string UserID);
       


    }
}
