﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace API.Commands;

public class Command : IDisposable
{
	public static List<Prefix> Prefixes;

	public static Prefix FindPrefix(string command)
	{
		return Prefixes.FirstOrDefault(x => x.Value.Equals(command, StringComparison.OrdinalIgnoreCase));
	}

	public static bool HasPrefix(string command, out Prefix prefix)
	{
		prefix = FindPrefix(command);
		return prefix != null;
	}

	public enum Types
	{
		Generic,
		Chat,
		Console,
		Rcon
	}

	public static bool FromRcon { get; set; }

	public string Name { get; set; }
	public string Help { get; set; }
	public object Token { get; set; }
	public object Reference { get; set; }
	public Types Type { get; set; }
	public CommandFlags Flags { get; set; } = CommandFlags.None;
	public Action<Args> Callback { get; set; }
	public Func<Command, Args, bool> CanExecute { get; set; }
	public ConsoleSystem.Command RustCommand { get; set; }

	internal const char _splitDelimiter = '.';

	public void Fetch()
	{
		Name = Name?.ToLower().Trim();
		Help = Help?.Trim();

		switch (this)
		{
			case RCon:
				Type = Types.Rcon;
				break;
			case ClientConsole:
				Type = Types.Console;
				break;
			case Chat:
				Type = Types.Chat;
				break;
			default:
				break;
		}

		if (RustCommand == null) RustCommand = new();

		var nameSplit = Name.Split(_splitDelimiter);
		var parent = nameSplit.Length > 1 ? nameSplit[0] : "global";
		var name = nameSplit.Length > 1 ? nameSplit[1] : Name;

		Array.Clear(nameSplit, 0, nameSplit.Length);
		nameSplit = null;

		RustCommand.Name = name;
		RustCommand.Parent = parent;
		RustCommand.FullName = Name;
		RustCommand.ServerUser = true;
		RustCommand.ServerAdmin = true;
		RustCommand.Client = true;
		RustCommand.ClientInfo = true;
		RustCommand.Variable = false;
	}

	public void Dispose()
	{
		Callback = null;
		CanExecute = null;
		RustCommand = null;
	}

	public class Prefix
	{
		public string Value;

		public bool PrintToChat;
		public bool PrintToConsole;

		public int SuggestionAuthLevel = 2;
	}

	public class Args : IDisposable
	{
		public Types Type { get; set; }
		public string[] Arguments { get; set; }

		public string Reply { get; set; }
		public object Token { get; set; }
		public bool IsRCon { get; set; }
		public bool IsServer { get; set; }
		public bool PrintOutput { get; set; }

		public bool Tokenize<T>(out T value)
		{
			return (value = (T)Token) != null;
		}

		public void ReplyWith(string message)
		{
			Reply = message;
		}
		public void ReplyWith<T>(T message)
		{
			Reply = JsonConvert.SerializeObject(message, Formatting.Indented);
		}

		public virtual void Dispose()
		{
			Type = Types.Generic;
			Reply = null;
			Token = null;

			if (Arguments != null)
			{
				Array.Clear(Arguments, 0, Arguments.Length);
				Arguments = null;
			}
		}
	}

	public class RCon : Command
	{

	}
	public class Chat : AuthenticatedCommand
	{

	}
	public class ClientConsole : AuthenticatedCommand
	{

	}

	public class Authentication
	{
		public int AuthLevel { get; set; }
		public string[] Permissions { get; set; }
		public string[] Groups { get; set; }
		public int Cooldown { get; set; }
	}

	public bool HasFlag(CommandFlags flag)
	{
		return (Flags & flag) != 0;
	}
	public void SetFlag(CommandFlags flag, bool wants)
	{
		switch (wants)
		{
			case true:
				Flags |= flag;
				break;

			case false:
				Flags &= ~flag;
				break;
		}
	}
	public void ClearFlags()
	{
		Flags = CommandFlags.None;
	}
}

public class AuthenticatedCommand : Command
{
	public Authentication Auth { get; set; }
}

public class PlayerArgs : Command.Args
{
	public object Player { get; set; }

	public bool GetPlayer<T>(out T value) where T : class
	{
		return (value = (T)Player) != null;
	}

	public override void Dispose()
	{
		Player = null;
		base.Dispose();
	}
}
