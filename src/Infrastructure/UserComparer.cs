using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using src.Model;

namespace src.Infrastructure
{
    public class UserComparer : IEqualityComparer<User>
    {
        public bool Equals([AllowNull] User x, [AllowNull] User y)
        {
            if (object.ReferenceEquals(x, y)) 
            {
                return true;
            }
            
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
        }

        public int GetHashCode([DisallowNull] User obj)
        {
            if (Object.ReferenceEquals(obj, null)) 
            {
                return 0;
            }

            int hashUseName = obj.Name.Equals(null) ? 0 : obj.Name.GetHashCode();

            int hashUserId = obj.Id.GetHashCode();

            return hashUseName ^ hashUserId;
        }
    }
}