using System;
using System.Collections.Generic;

/*
 *
 * Copyright (c) 2022-2024 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Assembly;

public interface IExtensionManager : IAddonManager
{
	public ExtensionTypes CurrentExtensionType { get; set; }

	public enum ExtensionTypes
	{
		Default,
		Extension,
		HarmonyMod,
		HarmonyModHotload
	}
}
