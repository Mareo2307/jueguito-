using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject MenuPaus;
    private bool JuegoPausado = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoPausado)
            {
                Resume();
            }
            else
            {
                Pausa();
            }
        }
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
        BotonPausa.SetActive(false);
        MenuPaus.SetActive(true);
        
    }
    
    
    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        BotonPausa.SetActive(true);
        MenuPaus.SetActive(false);
    }

    public void Exit() 
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }


    void FixedUpdate()
    {

        if (Input.GetKey("q"))
        {
            BotonPausa.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
