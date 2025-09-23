using MelonLoader;
using HarmonyLib;
using Il2CppBestHTTP;

[assembly: MelonInfo(typeof(Scanner.Core), "Scanner", "1.2.0", "ehko", null)]
[assembly: MelonGame("VRChat", "VRChat")]

namespace Scanner
{
    public class Core : MelonMod
    {
        public static string BaseUrl = "http://127.0.0.1:3000";

        public override void OnApplicationStart()
        {
            // Handle --forceUrl command line argument
            try
            {
                var args = Environment.GetCommandLineArgs();
                for (int i = 0; i < args.Length; i++)
                {
                    var a = args[i];
                    if (a.StartsWith("--forceUrl=", StringComparison.OrdinalIgnoreCase))
                    {
                        BaseUrl = a.Substring("--forceUrl=".Length);
                        MelonLogger.Msg($"[Scanner] Using forced BaseUrl (from --forceUrl=): {BaseUrl}");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[Scanner] Failed to parse command line args: " + ex);
            }

            var harmony = new HarmonyLib.Harmony("ehko.scanner");
            harmony.PatchAll();

            MelonLogger.Msg("[Scanner] Patches applied. BaseUrl = " + BaseUrl);
        }

        [HarmonyPatch]
        public static class Patch_SendRequest
        {

            static System.Reflection.MethodBase TargetMethod()
            {
                return typeof(HTTPManager).GetMethod(
                    "SendRequest",
                    new Type[] { typeof(HTTPRequest) }
                    );
            }

            public static bool Prefix(HTTPRequest request)
            {
                string path = request.Uri.PathAndQuery;
                string uri = Core.BaseUrl + path;
                Il2CppSystem.UriBuilder newURI = new Il2CppSystem.UriBuilder(uri);

                request.Uri = newURI.Uri;
                MelonLogger.Msg($"[HTTPManager] patched to: {uri}");
                return true;
            }
        }
    }
}
