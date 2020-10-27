using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext;

        public SQLUserRepository( AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public ApplicationUser GetUser(string UserID)
        {
            ApplicationUser user = appDbContext.Users.Find(UserID);
            return user;
            throw new NotImplementedException();
        }
    }
}
