using System;
using System.Collections.Generic;
using System.Text;
using Delegates.models;

namespace Delegates.Data
{
    public interface ILogin
    {
        User Login(string emailAddress, string password);

    }
}
