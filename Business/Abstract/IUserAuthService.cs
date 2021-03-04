using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserAuthService
    {
        IDataResult<List<OperationClaim>>  GetClaims(User user);
        IResult Add(User user);
        IDataResult<User>  GetByEmail(string email);
    }
}
