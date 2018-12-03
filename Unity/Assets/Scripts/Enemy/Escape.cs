using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Escape : MonoBehaviour {
    // Código também não utilizado na demo responsável por veirifcar se o player havia ou não se escondido, se estivesse escondido o inimigo iria voltar a patrulha.
    public IA ia;
    public NavMeshAgent agent;
    public EnemyPatrol ep;
    public ControlePersonagem player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            //ia.enabled = false;
            //ia.renderer.material.color = Color.blue;
            //agent.speed = 0;
            Debug.Log("Inimigo passou");
            Invoke("RestartSearch",5);
        }
        if(other.gameObject.CompareTag("Player"))
        {
            player.tag = "Untagged";
            ia.isAware = false;

        }
    }

    public void RestartSearch()
    {
        ia.isAware = false;
        ia.enabled = true;
    }
}

