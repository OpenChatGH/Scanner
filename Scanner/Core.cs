using MelonLoader;
using HarmonyLib;
using Il2CppBestHTTP;
using Il2CppExitGames.Client.Photon;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Reflection;

[assembly: MelonInfo(typeof(Scanner.Core), "Scanner", "1.2.0", "ehko", null)]
[assembly: MelonGame("VRChat", "VRChat")]

namespace Scanner
{
    public class Core : MelonMod
    {
        public static string BaseUrl = "http://localhost:3000";
        public static Il2CppSystem.String BasePhotonId = "dcbf2ef8-9d04-4538-a4e3-4a1647e6aea0";

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
                    else if (a.StartsWith("--forcePhotonId=", StringComparison.OrdinalIgnoreCase))
                    {
                        BasePhotonId = a.Substring("--forcePhotonId=".Length);
                        MelonLogger.Msg($"[Scanner] Using forced BasePhotonId (from --forcePhotonId=): {BasePhotonId}");
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
                return true;
            }
        }

        [HarmonyPatch]
        static class LogSerializeOperationToMessage
        {
            static System.Reflection.MethodBase TargetMethod()
            {
                return typeof(PeerBase).GetMethod(
                    "SerializeOperationToMessage",
                    new Type[] { typeof(byte), typeof(Il2CppSystem.Collections.Generic.Dictionary<byte, Il2CppSystem.Object>), typeof(EgMessageType), typeof(bool) });
            }

            public static bool Prefix(byte opCode, Il2CppSystem.Collections.Generic.Dictionary<byte, Il2CppSystem.Object> parameters, EgMessageType messageType, bool encrypt)
            {
                MelonLogger.Msg($"[PhotonSeralize] <Systems-Diction> {opCode} | {parameters} | {messageType} | {encrypt}");
                if(opCode == 220 && parameters != null) {
                    byte appIdKey = 224;

                    parameters[appIdKey] = (Il2CppSystem.Object)BasePhotonId;
                } else if (opCode == 230 && parameters != null)
                {
                    byte appIdKey = 224;

                    parameters[appIdKey] = (Il2CppSystem.Object)BasePhotonId;
                }
                return true;
            }

            public static void Postfix(byte opCode, Il2CppSystem.Collections.Generic.Dictionary<byte, Il2CppSystem.Object> parameters, EgMessageType messageType, bool encrypt)
            {
                DumpAll(parameters);
            }

            static void DumpAll(Il2CppSystem.Collections.Generic.Dictionary<byte, Il2CppSystem.Object> dict)
            {
                foreach (var kv in dict)
                    MelonLogger.Msg($"[AuthParam] {kv.Key} = {kv.Value}");
            }
        }
    }
}