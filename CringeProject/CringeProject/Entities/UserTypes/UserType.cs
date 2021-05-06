namespace CringeProject.Entities.UserTypes {
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
