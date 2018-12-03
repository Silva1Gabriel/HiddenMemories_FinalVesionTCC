using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    //Controle da visão do inimigo sentinela, onde o inimigo olhava para uma esfera invisivel que percorria uma distancia e depois retornava ao local realizando sempre esse looping;

    public GameObject startPos;
    public GameObject endPos;

    public bool teste;
    public float patrolTime = 5;



    void Start()
    {
        transform.position = startPos.transform.position;
    }


    void Update()
    {
        if (teste == false)
        {
            transform.position = Vector3.Lerp(transform.position, endPos.transform.position, Time.deltaTime);
            Invoke("Patrol", patrolTime);
        }
        if (teste == true)
        {
            transform.position = Vector3.Lerp(transform.position, startPos.transform.position, Time.deltaTime);
            Invoke("ReversePatrol", patrolTime);
        }
    }

    public void Patrol()
    {
        teste = true;
    }
    public void ReversePatrol()
    {
        teste = false;
    }
}
