using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public void LoadMod1Scene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}

/* 
Scene 'Main-MissionDemolition' couldn't be loaded because it has not been added to the build settings or the AssetBundle has not been loaded.
To add a scene to the build settings use the menu File->Build Settings...
UnityEngine.SceneManagement.SceneManager:LoadScene (string)
LoadNewScene:LoadMod1Scene (string) (at Assets/supportScripts/LoadNewScene.cs:11)
UnityEngine.EventSystems.EventSystem:Update ()
*/