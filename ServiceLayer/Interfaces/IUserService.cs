using ServiceLayer.DTOs;
using System.Collections.Generic;

namespace ServiceLayer.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAllUsers();
        void CreateUser(UserDTO userDTO);
        void EditUser(UserDTO userDTO);
        UserDTO GetUserByEmailandPassword(string emailOrUsername, string password);
    }
}