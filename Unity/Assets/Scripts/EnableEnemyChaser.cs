using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyChaser : MonoBehaviour {
    // Código não utilizado no game, onde o inimigo responsável pela perseguição era ativo quando o player se encontrava dentro do trigger.
    public GameObject ChaserEnemy;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaserEnemy.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ChaserEnemy.SetActive(false);
        }
    }
    
}
