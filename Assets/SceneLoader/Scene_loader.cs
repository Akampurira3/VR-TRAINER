using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.AddressableAssets.ResourceLocators;
public class Scene_loader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    //public Button sceneOne;
   // public Button sceneTwo;
   // public Button sceneThree;
  //  public Button sceneFour;
   // public Button sceneFive;
   // public Button sceneSix;
   // public Button nextScene;
   // public Button previousScene;
    

    // Update is called once per frame

    void start()
    {
        //sceneOne.onClick.AddListener(LoadNextSceneOne);
       // sceneTwo.onClick.AddListener(LoadNextSceneTwo);
       // sceneThree.onClick.AddListener(LoadNextSceneThree);
      //  sceneFour.onClick.AddListener(LoadNextSceneFour);
      //  sceneFive.onClick.AddListener(LoadNextSceneFive); 
      //  sceneSix.onClick.AddListener(LoadNextSceneSix);
     ///  nextScene.onClick.AddListener(LoadNextScene);
       // previousScene.onClick.AddListener(LoadPreviousScene);

    }

    public void LoadVrBasics()
    {
        
      
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadVrLocomotion()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadVrLocomotionBack()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 2));
    }
    public void LoadAreaLocomotion()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadPointLocomotion()
    {

        
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadPointLocomotionFromMenu()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 2));
    }
    public void LoadGrabbableObjects()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 4));
    }
    public void LoadGrabbableObjectsBack()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 2));
    }
    public void LoadDistanceGrab()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadDirectGrab()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadDirectGrabFromMenu()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 2));
    }

    public void LoadVrBasicsFromGrabbableObjects()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 4));
    }


    public void LoadSockets()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 7));
    }

    public void LoadVrBasicsFromSockets()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 7));
    }

    public void LoadEventsAndInteractions()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 9));
    }

    public void LoadWelcomeSceneFromEventsAndInteractions()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex  - 9));
    }

    public void LoadPaintingScene()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void EventsAndInteractionsFromLoadPaintingScene()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 1));
    }























    public void LoadNextSceneSix()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 6));
    }


    public void LoadNextScene()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreviousScene()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex -1));
    }



    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }

   

   }
    