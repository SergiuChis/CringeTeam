using CringeProject.Entities;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services
{
    public class ListenerService : BaseUserService
    {
        public ListenerService(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public string GetRoomName(Participation participation)
        {
            var roomName = _repository.Sections.Where(s => s.Id == participation.SectionId).Select(s => s.Room).ToList();
            return roomName[0];
        }

        public int GetAvailablePlaces(Participation participation)
        {
            var availablePlaces = _repository.Sections.Where(s => s.Id == participation.SectionId).Select(s => s.AvailablePlaces).ToList();
            return availablePlaces[0];
        }

        public IEnumerable<Review> GetAllReviews(User user) {
            var paperIds = _repository.Papers.Where(p => p.UserName == user.UserName).Select(p => p.Id);
            return _repository.Reviews.Where(r => paperIds.Contains(r.PaperId));
        }
    }
}
