using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from opertaionClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on opertaionClaim.Id equals UserOperationClaim.OperationClaimId
                             where UserOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = opertaionClaim.Id, Name = opertaionClaim.Name };
                return result.ToList();

            }
        }
    }
}
