using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Business.Concrete
{
    public class UserAuthManager :IUserAuthService
    {
        private IUserAuthDal _userAuthDal;

        public UserAuthManager(IUserAuthDal userAuthDal)
        {
            _userAuthDal = userAuthDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userAuthDal.GetClaims(user), Messages.ClaimsListed);
        }

        public IResult Add(User user)
        {
            _userAuthDal.Add(user);
          return  new SuccessResult(Messages.Added);
        }

        public IDataResult<User> GetByEmail(string email)
        {

            return new SuccessDataResult<User>(_userAuthDal.Get(u => u.Email == email));
        }

    }
}
