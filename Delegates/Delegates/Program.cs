using ClubMembershipApplication;
using Delegates.Views;
using System;

namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();
        }

    }

}