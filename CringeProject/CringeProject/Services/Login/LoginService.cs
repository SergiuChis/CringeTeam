using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Messages;
using CringeProject.Repository;

namespace CringeProject.Services.Login {
    public class LoginService {
        private readonly RepositoryContext _repository;

        public LoginService(RepositoryContext repository) {
            _repository = repository;
        }

        public Task<User> Authenticate(string username, string password) {
            try
            {
                return _repository.Users
                    .Where(u => u.UserName == username && u.Password == password).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Status> CreateUser(string username, string password, string confirmedPassword) {
            if (password != confirmedPassword)
                return new Status("Passwords don't match", false);
            if (username.Count(c => c == '@') != 1)
            {
                return new Status("Username is not an email", false);
            }
            if (password.Length < 3)
            {
                return new Status("Password too short", false);
            }

            var _ = _repository.Users.Find(username) ?? _repository.Users.Add(new User(username, password));

            try {
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status(e.Message, false);
            }

            return new Status("Success!", true);
        }
    }
}
