using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    //public Animator animator;
    public GameObject FadeOut;
   
    


    #region Pause
    PauseScript ps;
    #endregion
    #region Canvas
    public GameObject canvasMenu;
    public GameObject canvasSettings;
    #endregion
    #region Atributos da Câmera
    Vector3 cameraPosInicial = new Vector3(354, 1, -620);
    Vector3 cameraPosFinal = new Vector3(460, 1, -580);
    Vector3 cameraPosPlay = new Vector3(465, 1, -620);

    Vector3 cameraRotInicial = new Vector3(0, 0, 0);
    Vector3 cameraRotFinal = new Vector3(0, 70, 0);
    #endregion
    #region EstadoDoClick
    public bool playClick = false;
    public bool settingsClick = false;
    public bool backClick = false;
    #endregion


    void Start()
    {
        
        ps = GetComponent<PauseScript>();

        playClick = false;
        settingsClick = false;
        backClick = false;

        DisableSettings();
    }

    public void LateUpdate()
    {

        if (settingsClick == true)
        {
           
            
            DisableMenu();
            
            Invoke("EnableSettings", 0.5f);
            Settings();
        }

        if (backClick == true)
        {

            Back();
            DisableSettings();

            Invoke("EnableMenu", 0.5f);


        }

        if (playClick == true)
        {
            FadeOut.SetActive(true);

        }
    }
    public void PlayGame()
    {
        playClick = true;
        settingsClick = false;
        backClick = false;

        Time.timeScale = 1f;
        StartCoroutine(WaitForSceneLoad());
        // Habilita o inicio do jogo, onde ocorre o chamado para a próxima cena;
    }

    public void Settings()
    {
        // Ao ser selecionado no menu a posição da camera muda e um novo canvas surge.
        settingsClick = true;
        backClick = false;

        if (transform.position != cameraRotFinal)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPosFinal, 0.05f);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, cameraRotFinal, 0.05f);
        }


    }
    public void Exit()
    {
        // Sai do jogo.
        Application.Quit();
    }

    public void Back()
    {
        // sai da tela de setting e retorna a camera a posição inicial e o canvas padrão volta à cena.
        settingsClick = false;
        backClick = true;

        if (transform.position != cameraRotInicial)
        {
            transform.position = Vector3.Lerp(transform.position, cameraPosInicial, 0.05f);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, cameraRotInicial, 0.05f);
        }

    }

    void EnableMenu()
    {
        //Ativa o menu
        canvasMenu.SetActive(true);
    }
    void DisableMenu()
    {
        //Desativa o menu
        canvasMenu.SetActive(false);
    }
    void EnableSettings()
    {
        //Ativa os settings;
        canvasSettings.SetActive(true);
    }
    void DisableSettings()
    {
        //Desativa os settings;
        canvasSettings.SetActive(false);
    }

    private IEnumerator WaitForSceneLoad()
    {
        //Delay para o carregamento da próxima cena.
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Loading");

    }

    public void LoadCredits()
    {
        //carrega a cena de créditos;
        SceneManager.LoadScene("Credits");
        
       
    }
   

  

}


