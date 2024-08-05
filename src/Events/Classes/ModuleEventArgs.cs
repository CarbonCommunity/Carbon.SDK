using System.Collections.Generic;
using API.Assembly;

namespace API.Events;

public class ModuleEventArgs : CarbonEventArgs
{
	public IModulePackage ModulePackage;
	public IEnumerable<object> Data;

	public ModuleEventArgs(object payload, IModulePackage modulePackage, IEnumerable<object> data) : base(payload)
	{
		ModulePackage = modulePackage;
		Data = data;
	}
}
