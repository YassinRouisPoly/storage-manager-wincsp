﻿using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Services
{
    public class AuthenticationService
    {
        private User? loggedUser;
        private UsersRepository usersRepository;


        public AuthenticationService(IServiceProvider service)
        {
            usersRepository = service.GetRequiredService<UsersRepository>();
        }

        public bool IsLoggedIn()
        {
            return loggedUser != null;
        }

        public bool Login(string username, string password)
        {
            User user = usersRepository.FindByUsername(username);

            if (user == null) return false;

            var success = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            if (success)
            {
                loggedUser = user;
            }

            return success;
        }

        public void Logout()
        {
            loggedUser = null;
        }
    }
}
