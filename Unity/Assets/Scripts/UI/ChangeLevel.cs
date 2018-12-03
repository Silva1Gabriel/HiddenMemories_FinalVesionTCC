using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{// Código não mais utilizado devido a um bug que ocorria por usar a cena como Object e não sendo chamada pelo nome. ( na versão da Build!!!!)
    public GameObject FadeOutPreFab;
    public Object SceneToLoad;
    bool onTrigger = false;
    public void Start()
    {
        onTrigger = false;
    }

    private void Update()
    {
        if(onTrigger==true)
        {
            StartCoroutine(WaitChangeLevel());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ao entrar no trigger a troca de cena é iniciada
            onTrigger = true;
            FadeOutPreFab.SetActive(true);
        }
    }
    
 
    private IEnumerator WaitChangeLevel()
    {
        //Delay para a troca de level.
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneToLoad.name);
        
    }

}
