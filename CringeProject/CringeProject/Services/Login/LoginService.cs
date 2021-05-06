using System.Linq;
using CringeProject.Entities;
using CringeProject.Repository;

namespace CringeProject.Services.Login {
    public class LoginService {
        private readonly RepositoryContext _repository;

        public LoginService(RepositoryContext repository) {
            _repository = repository;
        }

        public User Authenticate(string username, string password) {
            return _repository.Users
                .FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
