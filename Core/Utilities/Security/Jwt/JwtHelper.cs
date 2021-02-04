using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public AccesToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            
        }
    }
}
