using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CringeProject.Repository;

namespace CringeProject.Services {
    public class PaperManagementService : BaseUserService {
        public PaperManagementService(RepositoryContext repository) : base(repository) { }
    }
}
