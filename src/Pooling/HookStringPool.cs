using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace Carbon.Pooling;

public class HookStringPool
{
	public static Dictionary<string, uint> HookNamePoolString = new();
	public static Dictionary<uint, string> HookNamePoolInt = new();

	internal static uint ManifestHash(string str)
	{
		if (string.IsNullOrEmpty(str))
			return 0;

		return BitConverter.ToUInt32(new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(str)), 0);
	}

	public static uint GetOrAdd(string name)
	{
		if (HookNamePoolString.TryGetValue(name, out var hash))
		{
			return hash;
		}

		hash = ManifestHash(name);
		HookNamePoolString[name] = hash;
		HookNamePoolInt[hash] = name;
		return hash;
	}


	public static string GetOrAdd(uint name)
	{
		if (HookNamePoolInt.TryGetValue(name, out var hash))
		{
			return hash;
		}

		return string.Empty;
	}
}
