using System;
using Example.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Example.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<StartViewModel>();
        }
    }
}
