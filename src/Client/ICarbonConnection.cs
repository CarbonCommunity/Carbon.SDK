using System.Net.Sockets;
using System.Threading.Tasks;
using Network;

namespace Carbon.Client.SDK;

public interface ICarbonConnection
{
	Network.Connection Connection { get; set; }
	BasePlayer Player { get; set; }
	TcpClient Net { get; set; }

	NetworkStream Stream { get; set; }

	bool IsCarbonConnected { get; }
	bool IsConnected { get; }
	bool IsDownloadingAddons { get; set; }
	bool HasData { get; }

	bool IsValid();
	void OnConnected();
	void OnDisconnect();
	ValueTask<bool> ConnectCarbon();
	void DisconnectCarbon(string reason);
}
