using AlphaService.Helpers;
using AlphaService.Models;
using AlphaService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AlphaServiceContext _context;

        public AuthRepository(AlphaServiceContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            var user = _context.Users.Where(u => u.Email == username).FirstOrDefaultAsync();
            return await user;
        }

        public bool IfUserExists(string username)
        {
            var existingUser = _context.Users.Where(u => u.Email.Equals(username)).Select(u => new User
            {
                Email = u.Email
            }).FirstOrDefault();

            if (existingUser == null)
            {
                return false;
            }
            return true;
        }

        public async Task<User> UserLoginAsync(User model,string pass)
        {
            var user = _context.Users.Where(u => u.Email == model.Email).Where(u => u.Password == pass).Select(u => new User
            {
                UserId = u.UserId,
                Email = u.Email
            }).FirstOrDefaultAsync();

            return await user;

        }

        public User UserRegistrationAsync(User model, string pass)
        {
            var user = new User
            {
                Email = model.Email,
                Password = pass
            };

            //Before registering check if the username is taken
            if (IfUserExists(model.Email))
            {
                return null;
            }
            return user;
        }
    }
}
