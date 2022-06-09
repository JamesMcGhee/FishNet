#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

namespace FishNet
{
    /// <summary>
    /// Making this public is not only okay but advisable
    /// Its already limited to the editor only and simply wont compille anywhere else, it is in a namespace so uniuqely named
    /// making it public means other tools outside this assembly can leverage its funcitonality which is good when making editor tools
    /// There is no need to hide this from anyone creating editor scripts
    /// </summary>
    public static class FishySteamDevTools
    {
        [MenuItem("Fish-Networking/Tools/Install and Upgrade/Steamworks Complete (Requires Heathen Sponsorship)", false)]
        public static void InstallSteamworksComplete()
        {
            StartCoroutine(SteamworksComplete());
        }

        [MenuItem("Fish-Networking/Tools/Install and Upgrade/Steamworks Foundation (Free)", false)]
        public static void InstallSteamworksFoundation()
        {
            StartCoroutine(SteamworksFoundation());
        }

        [MenuItem("Fish-Networking/Tools/Install and Upgrade/Steamworks.NET (Free)", false)]
        public static void InstallSteamworksNet()
        {
            StartCoroutine(SteamworksNet());
        }

        private static IEnumerator SteamworksComplete()
        {
            yield return null;
            AddRequest steamProc = null;

            if (!SessionState.GetBool("CompleteInstall", false))
            {
                SessionState.SetBool("CompleteInstall", true);
                steamProc = Client.Add("https://github.com/heathen-engineering/SourceRepo.git?path=/Steamworks/com.heathen.steamworkscomplete");
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks Complete install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks Complete " + steamProc.Result.version + " installation complete");
            else
            {
                Debug.Log("Installing Steamworks Complete ...");
                while (steamProc.Status == StatusCode.InProgress)
                {
                    yield return null;
                }
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks Complete install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks Complete " + steamProc.Result.version + " installation complete");

            SessionState.SetBool("CompleteInstall", false);
        }

        private static IEnumerator SteamworksFoundation()
        {
            yield return null;
            AddRequest steamProc = null;

            if (!SessionState.GetBool("FoundationInstall", false))
            {
                SessionState.SetBool("FoundationInstall", true);
                steamProc = Client.Add("https://github.com/heathen-engineering/SteamworksFoundation.git?path=/com.heathen.steamworksfoundation");
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks Foundation install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks Foundaiton " + steamProc.Result.version + " installation complete");
            else
            {
                Debug.Log("Installing Steamworks Foundation ...");
                while (steamProc.Status == StatusCode.InProgress)
                {
                    yield return null;
                }
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks Foundaiton install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks Foundaiton " + steamProc.Result.version + " installation complete");

            SessionState.SetBool("FoundationInstall", false);
        }

        private static IEnumerator SteamworksNet()
        {
            yield return null;
            AddRequest steamProc = null;

            if (!SessionState.GetBool("SteamInstall", false))
            {
                SessionState.SetBool("SteamInstall", true);
                steamProc = Client.Add("https://github.com/rlabrecque/Steamworks.NET.git?path=/com.rlabrecque.steamworks.net");
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks.NET install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks.NET " + steamProc.Result.version + " installation complete");
            else
            {
                Debug.Log("Installing Steamworks.NET ...");
                while (steamProc.Status == StatusCode.InProgress)
                {
                    yield return null;
                }
            }

            if (steamProc.Status == StatusCode.Failure)
                Debug.LogError("PackageManager Steamworks.NET install failed, Error Message: " + steamProc.Error.message);
            else if (steamProc.Status == StatusCode.Success)
                Debug.Log("Steamworks.NET " + steamProc.Result.version + " installation complete");

            SessionState.SetBool("SteamInstall", false);
        }

        private static List<IEnumerator> coroutines;

        private static void StartCoroutine(IEnumerator handle)
        {
            if (coroutines == null)
            {
                EditorApplication.update -= EditorUpdate;
                EditorApplication.update += EditorUpdate;
                coroutines = new List<IEnumerator>();
            }

            coroutines.Add(handle);
        }

        private static void EditorUpdate()
        {
            List<IEnumerator> done = new List<IEnumerator>();

            if (coroutines != null)
            {
                foreach (var e in coroutines)
                {
                    if (!e.MoveNext())
                        done.Add(e);
                    else
                    {
                        if (e.Current != null)
                            Debug.Log(e.Current.ToString());
                    }
                }
            }

            foreach (var d in done)
                coroutines.Remove(d);
        }
    }
}
#endif