using System;
using Carbon.Client.Contracts;
using Network;
using UnityEngine;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community
 * All rights reserved.
 *
 */

namespace Carbon.Client.SDK
{
	public interface ICarbonClient : ICommunication, IDisposable
	{
		Connection Connection { get; set; }
		BasePlayer Player { get; set; }
		bool HasCarbonClient { get; set; }

		void Send(string rpc, IPacket packet = null, bool bypassChecks = false);
		T Receive<T>(Message message);

		bool IsValid();
		void OnConnected();
		void OnDisconnect();

		#region RPCs

		void SpawnPrefab(string path, Vector3 position, Vector3 rotation, Vector3 scale, bool asynchronous = true);
		void SpawnPrefab(string path, Vector3 vector, Quaternion quaternion, Vector3 scale, bool asynchronous = true);
		void DestroyPrefab(string path);
		void DestroyAllPrefabs();
		void Uninstall(string addon);
		void UninstallAllAddons();

		#endregion
	}
}
