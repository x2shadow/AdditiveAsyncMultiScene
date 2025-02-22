using UnityEngine;
using UnityEngine.SceneManagement;
using UnityUtils;

public class Bootstrapper : PersistentSingleton<Bootstrapper> 
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static async void Init()
    {
        Debug.Log("Bootstrapper...");
        await SceneManager.LoadSceneAsync("Bootstrapper", LoadSceneMode.Single).AsTask();
    }
}