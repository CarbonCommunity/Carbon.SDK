using System;
using System.Threading.Tasks;

namespace API.Contracts;

public interface IDownloadManager
{
	/// <summary>
	/// Downloads the contents of the provided URL as an array of bytes.
	/// </summary>
	public Task<byte[]> Download(string url);

	/// <summary>
	/// Adds a download request for the provided URL to the download queue and
	/// triggers the specified callback when the task completes.
	/// </summary>
	public void DownloadAsync(string url, Action<string, byte[]> callback);
}
