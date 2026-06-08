using System;
using System.Security.Cryptography;
using System.Text;
using ITSupport.Models;
using ITSupport.Repositories;

namespace ITSupport.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;
        private User _currentUser;

        public AuthService()
        {
            _userRepository = new UserRepository();
        }

        public bool Login(string login, string password)
        {
            var user = _userRepository.GetByLogin(login);

            if (user != null && VerifyPassword(password, user.PasswordHash))
            {
                _currentUser = user;
                _userRepository.UpdateLastLogin(user.Id);
                return true;
            }

            return false;
        }

        public bool Register(string login, string password, string fullName, string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return false;

            if (_userRepository.GetByLogin(login.Trim()) != null)
                return false;

            var user = new User
            {
                Login = login.Trim(),
                PasswordHash = HashPassword(password),
                Role = "Employee",
                FullName = fullName?.Trim(),
                Email = email?.Trim(),
                Phone = phone?.Trim(),
                IsActive = true
            };

            _userRepository.Add(user);
            return true;
        }

        public void Logout()
        {
            _currentUser = null;
        }

        public User GetCurrentUser() => _currentUser;

        public bool IsAuthenticated() => _currentUser != null;

        public bool IsITSpecialist() =>
            _currentUser != null && _currentUser.Role == "ITSpecialist";

        public bool IsEmployee() =>
            _currentUser != null && _currentUser.Role == "Employee";

        private static bool VerifyPassword(string inputPassword, string storedHash)
        {
            return HashPassword(inputPassword).Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }

        public static string HashPassword(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hashBytes.Length * 2);
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
