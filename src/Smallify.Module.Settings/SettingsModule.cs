﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Smallify.Module.Settings.Configuration;
using Smallify.Module.Settings.ViewModels;
using Smallify.Module.Settings.Views;

namespace Smallify.Module.Settings
{
    public class SettingsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.Launch, typeof(SettingsButtonView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GeneralSectionView>();
            containerRegistry.RegisterForNavigation<AuthenticationSectionView>();
            containerRegistry.RegisterForNavigation<AboutSectionView>();

            ViewModelLocationProvider.Register(typeof(SettingsButtonView).ToString(), typeof(SettingsButtonViewModel));
            ViewModelLocationProvider.Register(typeof(SettingsShell).ToString(), typeof(SettingsShellViewModel));
            ViewModelLocationProvider.Register(typeof(GeneralSectionView).ToString(), typeof(GeneralSectionViewModel));
            ViewModelLocationProvider.Register(typeof(AuthenticationSectionView).ToString(), typeof(AuthenticationSectionViewModel));
            ViewModelLocationProvider.Register(typeof(AboutSectionView).ToString(), typeof(AboutSectionViewModel));
        }
    }
}
