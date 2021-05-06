using CringeProject.Entities;
using CringeProject.Entities.UserTypes;
using CringeProject.Messages;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services {
    public class MainMenuService {
        private readonly RepositoryContext _repository;

        public MainMenuService(RepositoryContext repositoryContext)
        {
            _repository = repositoryContext;
        }

        public List<Conference> GetAllConferences()
        {
            return _repository.Conferences.ToList();
        }

        public async Task<Status> AddConference(User creatingUser, string conferenceName, DateTime startDate, DateTime endDate, DateTime deadlineForAbstracts, DateTime deadlineForPapers, int numberOfSections)
        {
            Conference newConference = new Conference { Name = conferenceName, StartDate = startDate, EndDate = endDate, AbstractDeadline = deadlineForAbstracts, PaperDeadline = deadlineForPapers };
            _repository.Conferences.Add(newConference);
            _repository.Participations.Add(new Participation { SectionId = 1, UserName = creatingUser.UserName, UserType = new SteeringCommitteeMemberType().Type });
            try
            {
                // TODO change participations to confrenences rather than sections sau ceva de genu
                await _repository.SaveChangesAsync();
                return new Status("Success", true);
            }
            catch (Exception e)
            {
                return new Status("Failed to add conference", false);
            }
        }
    }
}
