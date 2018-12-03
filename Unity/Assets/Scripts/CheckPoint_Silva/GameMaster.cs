using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
    //Controlador do checkpoint (CheckPointManager) 
    public Scene scene;
    private static GameMaster instance;
    public Vector3 lastCheckPointPos;

    void Awake()
    {
      if(instance==null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
