using System;

/*
 *
 * Copyright (c) 2022-2024 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Assembly;

public interface ICarbonAddon
{
	public void Awake(EventArgs args);
	public void OnLoaded(EventArgs args);
	public void OnUnloaded(EventArgs args);
}
