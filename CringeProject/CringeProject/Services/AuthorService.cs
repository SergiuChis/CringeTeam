using CringeProject.Entities;
using CringeProject.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services
{
    class AuthorService : UserService
    {
        Status SubmitPaper(Paper paper, Conferrence conference)
        {
            return new Status("Successfully submitted", true);
        }
    }
}
