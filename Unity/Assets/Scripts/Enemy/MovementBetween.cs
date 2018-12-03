using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBetween : MonoBehaviour
{
    //Código não mais utilizado basicamente ele utilizava a mesma função da patrulha do inimigo porém era usado para mover plataformas;

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
