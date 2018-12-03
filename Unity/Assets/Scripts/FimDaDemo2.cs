using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimDaDemo2 : MonoBehaviour
{
    // Código que da inicio aos eventos de uma das versões da Demo ( onde a porta fechava, o relógio começava a tocar após a conclusão do puzzle e a luz começava a piscar) sendo que o monstro aparecia e eliminava o player.
    public Animator spotRoomLight;
    public Animator pointRoomLight;
    public Animator doorCLose;
    public ClockPuzzleManager CPM;
    public IA enemyScript;
    public GameObject enemy;
    public GameObject portal;



    void Update()
    {
        if(CPM.puzzleComplete==true)
        {
            
            
            StartCoroutine(EnemyTime());
            StartCoroutine(LightTime());
        }
    }
    public IEnumerator EnemyTime()
    {

        yield return new WaitForSeconds(10f);
        enemyScript.isAware = true;
        enemy.SetActive(true);
        portal.SetActive(true);


    }
    public IEnumerator LightTime()
    {
        yield return new WaitForSeconds(5f);
        spotRoomLight.SetBool("On", true);
        pointRoomLight.SetBool("On", true);
        doorCLose.SetBool("On", true);
    }
}
