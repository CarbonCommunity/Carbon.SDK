using System.Collections.Generic;
using Carbon.Client.Contracts;
using Carbon.SDK.Client;
using Network;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Client.SDK
{
	public interface ICarbonClientManager
	{
		Dictionary<Connection, ICarbonClient> Clients { get; }

		void Init();

		int AddonCount { get; }
		int AssetCount { get; }
		int SpawnablePrefabsCount { get; }
		int PrefabsCount { get; }
		int RustPrefabsCount { get; }
		int EntityCount { get; }

		void InstallAddons(string[] urls);
		void InstallAddonsAsync(string[] urls);
		void UninstallAddons();

		void ApplyPatch();

		void OnConnected(Connection connection);
		void OnDisconnected(Connection connection);

		void SendRequestsToAllPlayers(bool uninstallAll = true, bool loadingScreen = true);
		void SendRequestToPlayer(Connection connection, bool uninstallAll = true, bool loadingScreen = true);

		bool IsCarbonClient(BasePlayer player);
		bool IsCarbonClient(Connection connection);
		ICarbonClient Get(BasePlayer player);
		ICarbonClient Get(Connection connection);

		void NetworkClientConfiguration(ClientOptions options);

		void DisposeClient(ICarbonClient client);
	}
}
