using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserAuthDal : EfEntityRepositoryBase<User, RentingCarContext>, IUserAuthDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (RentingCarContext context = new RentingCarContext())
            {
                var result = from operatiomClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operatiomClaim.Id equals userOperationClaim.Id
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim {Id = operatiomClaim.Id, Name = operatiomClaim.Name};

                return result.ToList();
            }
            
        }
    }
}
