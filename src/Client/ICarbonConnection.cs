using System.Net.Sockets;
using System.Threading.Tasks;
using Network;

namespace Carbon.Client.SDK;

public interface ICarbonConnection
{
	string Ip { get; set; }
	ulong UserId { get; set; }
	string Username { get; set; }
	ulong Connection { get; set; }

	BasePlayer Player { get; set; }
	TcpClient Net { get; set; }

	NetworkStream Stream { get; set; }

	bool IsCarbonConnected { get; }
	bool IsDownloadingAddons { get; set; }
	bool HasData { get; }

	bool IsValid();
	void OnConnected(ulong userid, string username, string ip);
	void OnDisconnect();
	ValueTask<bool> ConnectCarbon();
	void DisconnectCarbon(string reason);
}
