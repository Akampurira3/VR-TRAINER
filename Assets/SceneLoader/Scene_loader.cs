using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_loader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public Button sceneOne;
    public Button sceneTwo;
    public Button sceneThree;
    public Button sceneFour;
    public Button sceneFive;
    public Button sceneSix;
    public Button nextScene;
    public Button previousScene;

    // Update is called once per frame

    void start()
    {
        sceneOne.onClick.AddListener(LoadNextSceneOne);
        sceneTwo.onClick.AddListener(LoadNextSceneTwo);
        sceneThree.onClick.AddListener(LoadNextSceneThree);
        sceneFour.onClick.AddListener(LoadNextSceneFour);
        sceneFive.onClick.AddListener(LoadNextSceneFive); 
        sceneSix.onClick.AddListener(LoadNextSceneSix);
        nextScene.onClick.AddListener(LoadNextScene);
        previousScene.onClick.AddListener(LoadPreviousScene);
    }

    public void LoadNextSceneOne()
    {
        
      
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadNextSceneTwo()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 2));
    }
    public void LoadNextSceneThree()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 3));
    }
    public void LoadNextSceneFour()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 4));
    }
    public void LoadNextSceneFive()
    {


        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 5));
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
