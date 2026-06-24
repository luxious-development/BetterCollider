using MSCLoader;
using System.IO;
using System.Reflection;
using UnityEngine;

public class DummyReference : Mod
{
    public override string ID => "BetterCollider_Dummy";
    public override string Author => null;
    public override string Version => null;
    public override Game SupportedGames => Game.MySummerCar_And_MyWinterCar;
    public override void ModSetup()
    {
        SetupFunction(Setup.OnMenuLoad, OnMenuLoad);
    }
    private void OnMenuLoad()
    {
        string dllPath = Assembly.GetExecutingAssembly().Location;
        string directory = Path.GetDirectoryName(dllPath);
        string folderName = Path.GetFileName(directory);
        if (folderName != "References")
        {
            GameObject host = new GameObject("BetterCollider_PopupHelper");
            host.AddComponent<PopupHelper>().message =
                "BetterCollider is not a mod, place it in References folder.";
            Object.DontDestroyOnLoad(host);
        }
    }
    private class PopupHelper : MonoBehaviour
    {
        public string message;
        private void Start()
        {
            StartCoroutine(ShowPopupNextFrame());
        }
        private System.Collections.IEnumerator ShowPopupNextFrame()
        {
            yield return new WaitForEndOfFrame();
            ModUI.ShowCustomMessage(
                message,
                "READ ME (IMPORTANT)",
                new MsgBoxBtn[1]
                {
                        ModUI.CreateMessageBoxBtn("OK", () =>
                        {
                            ModConsole.Error("BetterCollider is not usable until you move or remove");
                        }, noClosing: false)
                }
            );
        }
    }
}