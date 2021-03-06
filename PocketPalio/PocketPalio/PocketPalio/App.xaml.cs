﻿using Prism;
using Prism.Ioc;
using PocketPalio.ViewModels;
using PocketPalio.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PocketPalio
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("Dashboard");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<CharacterPage, CharacterPageViewModel>();
            containerRegistry.RegisterForNavigation<WardrobePage, WardrobePageViewModel>();
            containerRegistry.RegisterForNavigation<GamePage, GamePageViewModel>();
            containerRegistry.RegisterForNavigation<AccountPage, AccountPageViewModel>();
            containerRegistry.RegisterForNavigation<GoalPage, GoalPageViewModel>();
        }
    }
}
