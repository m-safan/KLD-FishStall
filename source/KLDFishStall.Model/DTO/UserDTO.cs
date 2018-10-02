using KLDFishStall.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLDFishStall.Model.DTO
{
    public class UserDTO : User, IDataTransferObject<User>
    {
        public UserDTO() { }

        public UserDTO(User item)
        {
            Email = item.Email;
            Id = item.Id;
            Name = item.Name;
            Role = item.Role;
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
