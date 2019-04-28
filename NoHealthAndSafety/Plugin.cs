using IPA;
using IPA.Config;
using IPA.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    public class Plugin : IBeatSaberPlugin
    {
        public void Init(IPALogger logger, [Config.Prefer("json")] IConfigProvider cfgProvider)
        {
            Logger.log = logger;       
        }

        public void OnApplicationStart()
        {

        }

        public void OnApplicationQuit()
        {

        }

        public void OnFixedUpdate()
        {

        }

        public void OnUpdate()
        {

        }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {
            if (nextScene.name == "HealthWarning")
            {
                new GameObject("ButtonPresser").AddComponent<ButtonPresser>();
            }
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {

        }

        public void OnSceneUnloaded(Scene scene)
        {

        }
    }
}
