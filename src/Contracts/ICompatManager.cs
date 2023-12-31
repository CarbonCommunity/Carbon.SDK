﻿namespace API.Assembly;

/*
 *
 * Copyright (c) 2023 Carbon Community
 * All rights reserved.
 *
 */

public interface ICompatManager
{
	public ConversionResult AttemptOxideConvert(ref byte[] asm);

	public bool ConvertHarmonyMod(ref byte[] data);
}

public enum ConversionResult
{
	Success,
	Fail,
	Skip
}
