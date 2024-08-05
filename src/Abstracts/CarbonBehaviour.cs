using System;

namespace API.Abstracts;

public abstract class CarbonBehaviour : FacepunchBehaviour
{
	public CarbonBehaviour()
	{
		// we can't use logger here until we migrate it to a component.
		Console.WriteLine($"A new instance of '{this}' created");
	}
}
