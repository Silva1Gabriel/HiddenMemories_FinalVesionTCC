using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
   // Como no código em questão as ações são muito semelhantes para evitar a repetição farei um resumo do que acontece.
   // Basicamente é realizada a ativação de um canvas e ou troca de cena, sendo que ao estar no pause o tempo da cena é zerado e ao retornar o tempo volta a ser igual a um.
    public  bool GameIsPaused = false;
   
    public GameObject pauseMenuUI;
    public GameObject soundMenuUI;

    private void Start()
    {
        GameIsPaused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
       
        GameOn();


    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        
        GamePaused();
        
        
    }

    public void Menu()
    {
        GamePaused();
        SceneManager.LoadScene("Attic");
    }
    public void Settings()
    {
        GamePaused();
        pauseMenuUI.SetActive(false);
        soundMenuUI.SetActive(true);

    }
    public void Back()
    {
        pauseMenuUI.SetActive(true);
        soundMenuUI.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GamePaused()
    {
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void GameOn()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;

    }
}

