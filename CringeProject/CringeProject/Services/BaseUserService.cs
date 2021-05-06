using CringeProject.Entities;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services {
    public class BaseUserService {
        private readonly RepositoryContext _repository;

        public BaseUserService(RepositoryContext repositoryContext)
        {
            _repository = repositoryContext;
        }

        public List<Conference> GetAllConferences()
        {
            return _repository.Conferences.ToList();
        }
    }
}
