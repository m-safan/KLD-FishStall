using KLDFishStall.Model;
using KLDFishStall.Model.DTO;
using KLDFishStall.Model.Models;
using KLDFishStall.Service.Contracts;
using System;

namespace KLDFishStall.Service
{
    public class UserService:IUserService
    {
        private IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public UserDTO Login(UserDTO user)
        {
            var validUser = _unitOfWork.User.
                 Get(x => x.Email.Equals(user.Email, StringComparison.InvariantCultureIgnoreCase) &&
                     x.Password.Equals(AESEncription.Decrypt(user.Password), StringComparison.InvariantCultureIgnoreCase));

            if (validUser == null)
                throw new Exception("User credentails did not match");

            return new UserDTO(validUser);
        }

        public UserDTO Register(UserDTO user)
        {
            User validUser = new User()
            {
                Email = user.Email,
                Password = AESEncription.Encrypt(user.Password),
                Name = user.Name,
                Role = "Admin"
            };
            validUser = _unitOfWork.User.Insert(validUser);
            _unitOfWork.Commit();

            return new UserDTO(validUser);
        }

        public UserDTO SocialNewtowkLogin(UserDTO user)
        {
            var validUser = _unitOfWork.User.Get(x => x.Email.Equals(user.Email, StringComparison.InvariantCultureIgnoreCase));

            if (validUser == null)
            {
                user.Password = user.Email;
                return Register(user);
            }

            return new UserDTO(validUser);
        }
    }
}
