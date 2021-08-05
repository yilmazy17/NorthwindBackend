using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserMenager:IUserService
    {
        private IUserDal _userDal;

        public UserMenager(IUserDal ıuserDal)
        {
            _userDal = ıuserDal;
        }


        public List<OperationClaim> GetClaims(User user)
        {
            return new List<OperationClaim>(_userDal.GetClaims(user).ToList());
        }

        public void Add(User user)
        {
            _userDal.Add(user);
            
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
