using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class LoadScene : MonoBehaviour
{// código não utilizado nesta versão final, porém basicamente era responsável por carregar o loading para a cena da casa.
    
    //public Object SceneToLoad;
    public GameObject doorOpenSound;
    public GameObject Fade;

    public NavMeshAgent agent;
    

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            doorOpenSound.SetActive(true);
            Fade.SetActive(true);
            agent.speed = 0;
            StartCoroutine(WaitForSceneLoad());
            
            
        }
    }
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("GroundFloor");

    }
   
}
