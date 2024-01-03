using System;

namespace Carbon.SDK.Client;

[Serializable]
public class ClientOptions
{
	public bool UseOldRecoil = false;
	public float ClientGravity = -1f;
	public float PlayerGravity = -1f;
}
