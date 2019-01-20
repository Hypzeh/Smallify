﻿using Smallify.Module.Notifications.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Smallify.Module.Notifications.ViewModels
{
	public interface INotificationsViewModel
	{
		ICommand DismissNotificationCommand { get; }

		ICommand ClearNotificationsCommand { get; }

		ObservableCollection<INotification> Notifications { get; }
	}
}