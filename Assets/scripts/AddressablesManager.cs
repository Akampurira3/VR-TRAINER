using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.AddressableAssets.ResourceLocators;

public class AddressablesManager : MonoBehaviour
{
    private bool clearPreviousScene = false;
    private SceneInstance previousLoadedScene;
    // Start is called before the first frame update
    void Start()
    {
        //START THE LOADER
        //Logger.Instance.LogInfo("Initializing Addressables.....");
        Addressables.InitializeAsync().Completed += AddressablesManager_Completed;


    }

    private void AddressablesManager_Completed(AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> obj)
    {
        //Logger.Instance.LogInfo("Instanlized Addressables.....");
    }

    public void LoadAddressablesLevel(string addressableKey)
    {
        if (clearPreviousScene)
        {
            Addressables.UnloadSceneAsync(previousLoadedScene).Completed += (asyncHandle) =>
            {
                clearPreviousScene = false;
                previousLoadedScene = new SceneInstance();
                //Logger.Instance.LogInfo($"Unloaded scene {addressableKey}.....");
            };

            Addressables.LoadSceneAsync(addressableKey, UnityEngine.SceneManagement.LoadSceneMode.Additive).Completed += (asyncHandle) =>
             {
                 clearPreviousScene = true;
                 previousLoadedScene = asyncHandle.Result;
                 //Logger.Instance.LogInfo($"Loaded scene {addressableKey} successfully");

             };
        }







    }



    //LEVEL LOADING


    // Update is called once per frame
    void Update()
    {
        
    }
}
