﻿using System;
using System.Collections.Generic;
using System.Text;
using Delegates.Views;
using Delegates.Data;
using Delegates.FieldValidators;

namespace ClubMembershipApplication
{
    public static class Factory
    {
        public static IView GetMainViewObject()
        {
            ILogin login = new LoginUser();
            IRegister register = new RegisterUser();
            IFieldValidator userRegistrationValidator = new UserRegistrationValidator(register);
            userRegistrationValidator.InitialiseValidatorDelegates();

            IView registerView = new UserRegistrationView(register, userRegistrationValidator);
            IView loginView = new UserLoginView(login);
            IView mainView = new MainView(registerView, loginView);

            return mainView;

        }
    }
}
