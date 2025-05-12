using Microsoft.Extensions.DependencyInjection;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;
using System;
using Microsoft.AspNetCore.Identity;

namespace StorageManager.Data.Services
{
    public class AuthenticationService
    {
        private User? _loggedUser;
        private readonly UsersRepository _usersRepository;
        private readonly LoggingService _loggingService;
        private readonly PasswordHasher<string> _hasher = new();

        public AuthenticationService(IServiceProvider service)
        {
            _usersRepository = service.GetRequiredService<UsersRepository>();
            _loggingService = service.GetRequiredService<LoggingService>();
        }

        public bool IsLoggedIn()
        {
            return _loggedUser != null;
        }

        public bool Login(string username, string password)
        {
            try
            {
                _loggingService.Log($"Login attempt for user: {username}", LoggingService.LogLevel.Info);

                User user = _usersRepository.FindByUsername(username);

                if (user == null)
                {
                    _loggingService.Log($"User not found: {username}", LoggingService.LogLevel.Warning);
                    return false;
                }

                var result = _hasher.VerifyHashedPassword(null, user.PasswordHash, password);
                bool success = result == PasswordVerificationResult.Success;

                if (success)
                {
                    _loggedUser = user;
                    _loggingService.Log($"User logged in: {username}", LoggingService.LogLevel.Info);
                }
                else
                {
                    _loggingService.Log($"Invalid password for user: {username}", LoggingService.LogLevel.Warning);
                }

                return success;
            }
            catch (Exception ex)
            {
                _loggingService.Log($"Login failed for user: {username}. Error: {ex.Message}", LoggingService.LogLevel.Error);
                return false;
            }
        }

        public void Logout()
        {
            if (_loggedUser != null)
            {
                _loggingService.Log($"User logged out: {_loggedUser.Username}", LoggingService.LogLevel.Info);
                _loggedUser = null;
            }
        }
    }
}