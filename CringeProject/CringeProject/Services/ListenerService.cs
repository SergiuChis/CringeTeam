using CringeProject.Entities;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services
{
    public class ListenerService
    {
        private readonly RepositoryContext _repository;

        public ListenerService(RepositoryContext repositoryContext)
        {
            _repository = repositoryContext;
        }

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
    }
}
