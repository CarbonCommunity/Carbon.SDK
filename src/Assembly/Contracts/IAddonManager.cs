using System;
using System.Collections.Generic;

/*
 *
 * Copyright (c) 2022-2024 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Assembly;

public interface IAddonManager
{
	public WatchFolder Watcher { get; }

	public byte[] Read(string file);
	public IReadOnlyDictionary<Type, KeyValuePair<string, byte[]>> Loaded { get; }
	public IReadOnlyDictionary<Type, string> Shared { get; }
	public System.Reflection.Assembly Load(string file, string requester);

	public void Unload(string file, string requester);
}
