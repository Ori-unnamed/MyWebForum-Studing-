using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebForum.Exceptions
{
    public class UserAccountDataException:Exception
    {
        public UserAccountDataException(string message) : base("UserAccountDataException is"+message)
        {

        }
    }
}
