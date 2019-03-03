﻿namespace Smallify.Module.Core
{
	public interface IConfiguration
	{
		string ClientID { get; }

		string AccessToken { get; set; }

		string Verion { get; }

		bool AlwaysOnTop { get; set; }
	}
}