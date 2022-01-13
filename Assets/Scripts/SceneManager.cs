using System;
using System.Web;
using UnityEngine;

namespace FlowEnt.Demo
{
    public class SceneManager : MonoBehaviour
    {
#pragma warning disable IDE0051, RCS1213
        private void Awake()
        {
#if UNITY_EDITOR
            const string url = "https://demo.flowent.friedsynapse.com?scdene=character";
#else
        string url = Application.absoluteURL;
#endif
            Uri myUri = new Uri(url);
            string sceneParam = HttpUtility.ParseQueryString(myUri.Query).Get("scene");
            string sceneName = sceneParam switch
            {
                "character" => "FlowEnt.Demo.Character",
                _ => "FlowEnt.Demo",
            };
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
#pragma warning restore IDE0051, RCS1213
    }
}