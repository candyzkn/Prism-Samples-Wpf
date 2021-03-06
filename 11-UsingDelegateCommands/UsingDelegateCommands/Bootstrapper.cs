﻿using Microsoft.Practices.Unity;
using Prism.Unity;
using UsingDelegateCommands.Views;
using System.Windows;

namespace UsingDelegateCommands
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
