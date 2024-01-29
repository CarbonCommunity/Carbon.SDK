﻿using System;

/*
 *
 * Copyright (c) 2022-2024 Carbon Community
 * All rights reserved.
 *
 */

namespace API.Assembly;

public interface ICarbonComponent : ICarbonAddon
{
	public void OnEnable(EventArgs args);
	public void OnDisable(EventArgs args);
}
