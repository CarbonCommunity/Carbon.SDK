﻿using System;
using System.Reflection;
using JetBrains.Annotations;
using Oxide.Core;

[AttributeUsage(AttributeTargets.Class)]
[MeansImplicitUse]
public class InfoAttribute : Attribute
{
	public string Title { get; }
	public string Author { get; }
	public VersionNumber Version { get; private set; }
	public int ResourceId { get; set; }

	public InfoAttribute(string Title, string Author, string Version)
	{
		this.Title = Title;
		this.Author = Author;
		this.Version = new VersionNumber(Version);
	}
	public InfoAttribute(string Title, string Author, double Version)
	{
		this.Title = Title;
		this.Author = Author;
		this.Version = new VersionNumber(Version.ToString());
	}
}

[AttributeUsage(AttributeTargets.Class)]
[MeansImplicitUse]
public class DescriptionAttribute : Attribute
{
	public string Description { get; }

	public DescriptionAttribute(string description)
	{
		Description = description;
	}
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field)]
[MeansImplicitUse]
public class PluginReferenceAttribute : Attribute
{
	public string Name { get; set; }
	public string MinVersion { get; set; }
	public bool IsRequired { get; set; }

	public FieldInfo Field { get; set; }

	public PluginReferenceAttribute() { }
	public PluginReferenceAttribute(string name = null, string minVersion = null, bool isRequired = false)
	{
		Name = name;
		MinVersion = minVersion;
		IsRequired = isRequired;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class CommandAttribute : Attribute
{
	public string[] Names { get; } = new string[1];

	public CommandAttribute(string name)
	{
		Names[0] = name;
	}

	public CommandAttribute(params string[] commands)
	{
		Names = commands;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class ChatCommandAttribute : Attribute
{
	public string Name { get; }
	public string Help { get; }

	public ChatCommandAttribute(string name, string help = null)
	{
		Name = name;
		Help = help;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class ConsoleCommandAttribute : Attribute
{
	public string Name { get; }
	public string Help { get; }

	public ConsoleCommandAttribute(string name)
	{
		Name = name;
	}

	public ConsoleCommandAttribute(string name, string help)
	{
		Name = name;
		Help = help;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class RConCommandAttribute : Attribute
{
	public string Name { get; }
	public string Help { get; }

	public RConCommandAttribute(string name, string help = null)
	{
		Name = name;
		Help = help;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class ProtectedCommandAttribute : Attribute
{
	public string Name { get; }
	public string Help { get; }

	public ProtectedCommandAttribute(string name)
	{
		Name = name;
	}

	public ProtectedCommandAttribute(string name, string help)
	{
		Name = name;
		Help = help;
	}
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
[MeansImplicitUse]
public class CommandVarAttribute : Attribute
{
	public string Name { get; }
	public string Help { get; }
	public bool Protected { get; set; }

	public CommandVarAttribute(string name, string help = null)
	{
		Name = name;
		Help = help;
	}
	public CommandVarAttribute(string name, bool @protected, string help = null)
	{
		Name = name;
		Help = help;
		Protected = @protected;
	}
}

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class HookMethodAttribute : Attribute
{
	public string Name { get; set; }
	public MethodInfo Method { get; set; }

	public HookMethodAttribute() { }
	public HookMethodAttribute(string name)
	{
		Name = name;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class PermissionAttribute : Attribute
{
	public string Name { get; }

	public PermissionAttribute(string permission)
	{
		Name = permission;
	}
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[MeansImplicitUse]
public class GroupAttribute : Attribute
{
	public string Name { get; }

	public GroupAttribute(string group)
	{
		Name = group;
	}
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
[MeansImplicitUse]
public class AuthLevelAttribute : Attribute
{
	public int AuthLevel { get; }

	public AuthLevelAttribute(int level)
	{
		AuthLevel = level;
	}
}

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class CooldownAttribute : Attribute
{
	public int Miliseconds { get; } = 0;

	public CooldownAttribute(int miliseconds)
	{
		Miliseconds = miliseconds;
	}
}

[AttributeUsage(AttributeTargets.Class)]
[MeansImplicitUse]
public class HotloadableAttribute : Attribute
{

}

[AttributeUsage(AttributeTargets.All)]
[MeansImplicitUse]
public class ConditionalAttribute : Attribute
{
	public string Symbol { get;set; }

	public ConditionalAttribute() { }
	public ConditionalAttribute(string symbol)
	{
		Symbol = symbol;
	}
}
