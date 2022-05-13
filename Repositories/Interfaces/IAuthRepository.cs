using AlphaService.Models;
using AlphaService.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        public Task<User> UserLoginAsync(User model,string pass);
        public User UserRegistrationAsync(User model, string pass);
        public bool IfUserExists(string username);

        public Task<User> GetUserByUsernameAsync(string username);
    }
}
