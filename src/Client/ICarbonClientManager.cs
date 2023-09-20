using System.Collections.Generic;
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

		void OnConnected(Connection connection);
		void OnDisconnected(Connection connection);

		bool IsCarbonClient(BasePlayer player);
		bool IsCarbonClient(Connection connection);
		ICarbonClient Get(BasePlayer player);
		ICarbonClient Get(Connection connection);

		void DisposeClient(ICarbonClient client);
	}
}
