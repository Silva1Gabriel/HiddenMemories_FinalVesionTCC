using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPoraoLoading : MonoBehaviour {

    //Loading do térreo da casa para a tela de loading que carregará o porão, onde ao interagir com a escada o player perde controle do personagem a tela congela, a cena entra em fade.
    public GameObject FadeOutToLoadingPorao;
    // Use this for initialization
    public bool fadeAtivo = false;
    public Animator animPlayer;
    public MoveCharacterTuca MTC;

    public void Update()
    {
        if(fadeAtivo==true)
        {
            StartCoroutine(Delay());
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player" && Input.GetKeyDown(KeyCode.E))
        {
            FadeOutToLoadingPorao.SetActive(true);
            fadeAtivo = true;
            animPlayer.enabled = false;
            MTC.enabled = false;
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("LoadingPorao");
    }
 }
