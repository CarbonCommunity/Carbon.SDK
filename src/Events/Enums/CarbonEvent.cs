﻿/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Events;

public enum CarbonEvent
{
	// Startup events
	StartupShared, StartupSharedComplete,
	FileSystemWarmup, FileSystemWarmupComplete,

	// Carbon related
	CarbonStartup, CarbonStartupComplete, CarbonShutdown, CarbonShutdownComplete, CarbonShutdownFailed,

	// Hook related
	HooksInstalled, HookValidatorRefreshed, InitialHooksInstalled,

	// Component related
	ComponentLoaded, ComponentUnloaded, ComponentLoadFailed, ComponentUnloadFailed,

	// Extension related
	ExtensionLoaded, ExtensionUnloaded, ExtensionLoadFailed, ExtensionUnloadFailed,

	// Harmony related
	HarmonyLoaded, HarmonyLoadFailed,

	// Module related
	ModuleLoaded, ModuleUnloaded, ModuleLoadFailed, ModuleUnloadFailed,

	// Plugin related
	AllPluginsLoaded, PluginPreload, PluginLoaded, PluginUnloaded,

	// Things that look like hooks
	OnServerInitialized, OnServerSave
}
