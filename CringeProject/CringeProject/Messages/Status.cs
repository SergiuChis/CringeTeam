using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Messages
{
    class Status
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; }

        public Status(string message, bool success)
        {
            Message = message;
            IsSuccessful = success;
        }
    }
}
