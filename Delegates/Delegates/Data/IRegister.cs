using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Data
{
    public interface IRegister
    {
        bool Register(string[] fields);
        bool EmailExists(string emailAddress);
    }
}
