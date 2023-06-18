using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace SOTFPostProcessing.Loader.Common;

public abstract class UPluginBase
{
    protected UPluginBase()
    {
        if (UPlugin.SUBSCRIBE_TO_SCENES)
        {
            SceneManager.sceneLoaded += (Action<Scene, LoadSceneMode>)OnSceneLoadedInternal;
            SceneManager.sceneUnloaded += (Action<Scene>)OnSceneUnloadedInternal;
        }
    }
    
    private void OnSceneLoadedInternal(Scene scene, LoadSceneMode mode)
    {
        OnSceneLoaded(scene, mode);
    }
    
    private void OnSceneUnloadedInternal(Scene scene)
    {
        OnSceneUnloaded(scene);
        
        if (scene.name == "SonsMainLoading")
        {
            OnInGame();
        }
    }

    protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }
    protected virtual void OnSceneUnloaded(Scene scene) { }

    protected virtual void OnInGame()
    {
        
    }
}