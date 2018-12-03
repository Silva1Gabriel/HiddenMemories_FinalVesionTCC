using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
    // responsável por guardar as informaçãoes de posição de checkpoint.
    private GameMaster gm;

     void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.tag=="Player")
        {
            gm.lastCheckPointPos = transform.position;
        }
    }
}
