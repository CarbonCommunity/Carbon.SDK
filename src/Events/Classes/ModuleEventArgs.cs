using System;
using System.Collections.Generic;
using API.Assembly;

/*
 *
 * Copyright (c) 2022-2023 Carbon Community 
 * All rights reserved.
 *
 */

namespace API.Events;

public class ModuleEventArgs : CarbonEventArgs
{
	public ICarbonModule Module;
	public IEnumerable<object> Data;

	public ModuleEventArgs(object payload, ICarbonModule module, IEnumerable<object> data) : base(payload)
	{
		Module = module;
		Data = data;
	}
}
