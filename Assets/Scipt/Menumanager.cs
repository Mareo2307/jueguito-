using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menumanager : MonoBehaviour
{

    [SerializeField] private Button play;
    [SerializeField] private Button resume;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject Pause;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
    }

    public void Exit() 
    {
        Application.Quit();
    }


    void FixedUpdate()
    {

        if (Input.GetKey("q"))
        {
            Pause.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
