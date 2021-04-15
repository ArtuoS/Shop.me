using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Utils
{
    public static class CurrentLoggedInUser
    {
        public static User User { get; private set; }

        public static void SetLoggedUser(User user)
        {
            if (user != null)
                User = user;
        }
    }
}


