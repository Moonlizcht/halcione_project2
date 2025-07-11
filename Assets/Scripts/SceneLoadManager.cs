using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    [SerializeField] private float transitionTime = 1f;
    private Animator transitionAnimator;
    void Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        //Disparar el trigger para reproducir animación Fadein
        transitionAnimator.SetTrigger("StartTransition");
        //Esperar un segundo
        yield return new WaitForSeconds(transitionTime);
        //Cargar la escena
        SceneManager.LoadScene(sceneIndex);
    }
}


