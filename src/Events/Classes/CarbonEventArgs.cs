using System;

namespace API.Events;

public class CarbonEventArgs : EventArgs
{
	public object Payload { get; }

	public CarbonEventArgs(object payload)
	{
		Payload = payload;
	}
}
