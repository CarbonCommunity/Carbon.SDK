namespace API.Assembly;

public interface IExtensionManager : IAddonManager
{
	public ExtensionTypes CurrentExtensionType { get; set; }

	public enum ExtensionTypes
	{
		Default,
		Extension,
		HarmonyMod,
		HarmonyModHotload
	}
}
