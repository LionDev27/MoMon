using UnityEngine;
using UnityEngine.SceneManagement;

public static class Bootstrapper
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void Initialize()
    {
        // Initialize default service locator.
        ServiceLocator.Initialize();

        // Register all your services next.

        // Application is ready to start, load your main scene.
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
    }
}