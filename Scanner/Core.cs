using System;
using System.Linq;
using MelonLoader;
using HarmonyLib;
using Il2CppVRC.Core;
using Il2CppBestHTTP;

[assembly: MelonInfo(typeof(Scanner.Core), "Scanner", "1.0.0", "ehko", null)]
[assembly: MelonGame("VRChat", "VRChat")]

namespace Scanner
{
    public class Core : MelonMod
    {
        public static string BaseUrl = "http://localhost:3000/api/1/";

        public override void OnApplicationStart()
        {
            // check command line args for --forceUrl
            try
            {
                var args = Environment.GetCommandLineArgs();
                for (int i = 0; i < args.Length; i++)
                {
                    var a = args[i];
                    if (a.StartsWith("--forceUrl=", StringComparison.OrdinalIgnoreCase))
                    {
                        BaseUrl = NormalizeBaseUrl(a.Substring("--forceUrl=".Length));
                        MelonLogger.Msg($"[Scanner] Using forced BaseUrl (from --forceUrl=): {BaseUrl}");
                        break;
                    }
                    if (a.Equals("--forceUrl", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    {
                        BaseUrl = NormalizeBaseUrl(args[i + 1]);
                        MelonLogger.Msg($"[Scanner] Using forced BaseUrl (from --forceUrl <value>): {BaseUrl}");
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

        private static string NormalizeBaseUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return BaseUrl;
            url = url.Trim();
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
            }
            if (!url.EndsWith("/")) url += "/";
            return url;
        }
    }

    [HarmonyPatch(typeof(API), nameof(API.GetApiUrl))]
    public static class Patch_API_GetApiUrl
    {
        public static bool Prefix(ref string __result)
        {
            __result = Core.BaseUrl;
            return false;
        }
    }

    [HarmonyPatch(typeof(API), "get_API_URL")]
    public static class Patch_API_get_API_URL
    {
        public static bool Prefix(ref string __result)
        {
            __result = Core.BaseUrl;
            return false;
        }
    }

    [HarmonyPatch(typeof(API), "SendRequest")]
    public static class Patch_API_SendRequest_ForceEndpoint
    {
        public static void Prefix(ref string endpoint, HTTPMethods method)
        {
            try
            {
                if (string.IsNullOrEmpty(endpoint))
                {
                    endpoint = Core.BaseUrl;
                    return;
                }

                if (!endpoint.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    var cleaned = endpoint.StartsWith("/") ? endpoint.Substring(1) : endpoint;
                    endpoint = Core.BaseUrl + cleaned;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[Scanner] SendRequest patch failed: " + ex);
            }
        }
    }

    [HarmonyPatch(typeof(API), "SendRequestInternal")]
    public static class Patch_API_SendRequestInternal_ForceEndpoint
    {
        public static void Prefix(ref string endpoint, HTTPMethods method)
        {
            try
            {
                if (string.IsNullOrEmpty(endpoint))
                {
                    endpoint = Core.BaseUrl;
                    return;
                }

                if (!endpoint.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    var cleaned = endpoint.StartsWith("/") ? endpoint.Substring(1) : endpoint;
                    endpoint = Core.BaseUrl + cleaned;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[Scanner] SendRequestInternal patch failed: " + ex);
            }
        }
    }
}
