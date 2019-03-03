﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Smallify.Module.Player.Constants;
using Smallify.Module.Player.Services;
using Smallify.Module.Player.ViewModels;
using Smallify.Module.Player.Views;

namespace Smallify.Module.Player
{
	public class PlayerModule : IModule
	{
		public void OnInitialized(IContainerProvider containerProvider)
		{
			var regionManager = containerProvider.Resolve<IRegionManager>();
			regionManager.RegisterViewWithRegion(RegionNames.PLAYER_CONTENT_REGION, typeof(PlayerView));
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.Register<ISpotifyService, SpotifyService>();

			containerRegistry.Register<IPlayerViewModel, PlayerViewModel>();
		}
	}
}