using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Entities {
    public abstract class UserType {
        public string Type { get; protected set; }

        public override bool Equals(object obj)
        {
            return Type == ((UserType)obj).Type;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(UserType a, UserType b)
        {
            return a.Type == b.Type;
        }

        public static bool operator !=(UserType a, UserType b)
        {
            return a.Type != b.Type;
        }
    }
}
