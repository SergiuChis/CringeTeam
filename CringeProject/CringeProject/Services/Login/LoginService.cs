using System;
using CringeProject.Entities;
using CringeProject.Repository;
using System.Linq;

namespace CringeProject.Services {
    public class LoginService {
        private readonly RepositoryContext _repository;

        public LoginService(RepositoryContext repository) {
            _repository = repository;
        }

        public User Authenticate(string username, string password) {
            _repository.Users.Add(new User("a", "b") { Id = 1 });
            _repository.Conferences.Add(new Conference { Id = 1, Name = "conf", SubmissionDeadline = new DateTime(2021, 10, 3) });
            _repository.Sections.Add(new Section { Id = 1, ConferenceId = 1, Room = "aaa", AvailablePlaces = 2 });
            _repository.Participations.Add(new Participation { UserId = 1, SectionId = 1, UserType = "Listener" });

            return _repository.Users
                .FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
