using System;
using System.Web;
using UnityEngine;

namespace FlowEnt.Demo
{
    public class SceneManager : MonoBehaviour
    {
        private void Awake()
        {
#if UNITY_EDITOR
            const string url = "https://demo.flowent.friedsynapse.com?scdene=character";
#else
            string url = Application.absoluteURL;
#endif
            Uri myUri = new(url);
            string sceneParam = HttpUtility.ParseQueryString(myUri.Query).Get("scene");
            string sceneName = sceneParam switch
            {
                "echoes" => "FlowEnt.Demo.Echoes",
                "authoring" => "FlowEnt.Demo.Authoring",
                _ => "FlowEnt.Demo",
            };
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}