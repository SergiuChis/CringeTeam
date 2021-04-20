using CringeProject.Entities;
using CringeProject.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Services
{
    class UserService
    {
        Status Pay(Conference conference)
        {
            return new Status("Payment successful", true);
        }
    }
}
