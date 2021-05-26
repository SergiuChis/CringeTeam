using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Entities;
using CringeProject.Messages;
using CringeProject.Repository;

namespace CringeProject.Services
{
    public abstract class BaseUserService
    {
        protected readonly RepositoryContext _repository;

        protected BaseUserService(RepositoryContext repository) {
            _repository = repository;
        }

        public async Task<IEnumerable<Paper>> GetPapersForUser(User user) {
            return await _repository.Papers.Where(p => p.UserName == user.UserName).ToListAsync();
        }

        public async Task<Status> AddPaperAsync(User user, int sectionId, string title, string abstract_, string body) {
            var participation = _repository.Participations.FirstOrDefault(p => p.SectionId == sectionId);
            var conferenceId = _repository.Sections
                .Where(s => s.Id == participation.SectionId)
                .Select(s => s.ConferenceId)
                .FirstOrDefault();
            var conference = _repository.Conferences.FirstOrDefault(c => c.Id == conferenceId);

            if (conference?.PaperDeadline > DateTime.Now) {
                return new Status("Paper submit date has passed.", false);
            }

            if (string.IsNullOrEmpty(title) || (string.IsNullOrEmpty(abstract_) && string.IsNullOrEmpty(body)))
                return new Status("Invalid paper.", false);

            var paper = new Paper(title, abstract_, body) {UserName = user.UserName, SectionId = sectionId};

            try {
                _repository.Papers.Add(paper);
                await _repository.SaveChangesAsync();
            }
            catch (Exception e) {
                return new Status("Error adding new paper.", false);
            }

            return new Status("Success!", true);
        }

        public async Task<Status> UpdatePaperAsync(int paperId, string newAbstract_, string newBody) {
            var paper = _repository.Papers.FirstOrDefault(p => p.Id == paperId);

            if (paper == null)
                return new Status("Invalid paper ID.", false);

            if (!string.IsNullOrEmpty(newAbstract_))
                paper.Abstract = newAbstract_;
            if (!string.IsNullOrEmpty(newBody))
                paper.Body = newBody;

            try {
                await _repository.SaveChangesAsync();
            }
            catch (Exception) {
                return new Status("Error updating paper.", false);
            }

            return new Status("Success!", true);
        }
    }
}
