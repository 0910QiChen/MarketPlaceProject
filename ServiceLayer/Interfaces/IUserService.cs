using ServiceLayer.DTOs;

namespace ServiceLayer.Interfaces
{
    public interface IUserService
    {
        void createUser(UserDTO userDTO);
        void editUser(UserDTO userDTO);
    }
}