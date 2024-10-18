using Network;

namespace Carbon.Client.SDK;

public interface ICarbonClient
{
	Network.Connection Connection { get; set; }
	BasePlayer Player { get; set; }

	bool IsConnected { get; }
	bool HasCarbonClient { get; set; }
	bool IsDownloadingAddons { get; set; }

	bool IsValid();
	void OnConnected();
	void OnDisconnect();
}
