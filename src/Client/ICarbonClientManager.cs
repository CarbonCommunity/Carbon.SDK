using System.Collections.Generic;
using Network;

namespace Carbon.Client.SDK;

public interface ICarbonClientManager
{
	public void Init();

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

	bool IsCarbonClient(BasePlayer player);
	bool IsCarbonClient(Connection connection);
	ICarbonConnection Get(BasePlayer player);
	ICarbonConnection Get(Connection connection);

	void DisposeClient(ICarbonConnection client);
}
