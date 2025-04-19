using Delegates.FieldValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Views
{
    public interface IView
    {
        void RunView();
        IFieldValidator FieldValidator { get; }
    }
}
