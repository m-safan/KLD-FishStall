using KLDFishStall.Model.DTO;

namespace KLDFishStall.Service.Contracts
{
    public interface IUserService
    {
        UserDTO Login(UserDTO user);

        UserDTO SocialNewtowkLogin(UserDTO user);

        UserDTO Register(UserDTO user);
    }
}
