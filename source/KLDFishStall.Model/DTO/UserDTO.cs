using KLDFishStall.Model.Models;
using System;

namespace KLDFishStall.Model.DTO
{
    public class UserDTO : User, IDataTransferObject<User>
    {
        public UserDTO() { }

        public UserDTO(User item, IUnitOfWork unitOfWork = null)
        {
            Email = item.Email;
            Id = item.Id;
            Name = item.Name;
            Role = item.Role;

            GetInnerDetails(unitOfWork);
        }

        public void GetInnerDetails(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) return;
        }

        public User Map()
        {
            return new User()
            {
                Email = this.Email,
                Name = this.Name,
                Role = this.Role
            };
        }
    }
}
