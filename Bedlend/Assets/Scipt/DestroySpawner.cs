using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawner;
    
    void Start()
    {
       
        int i  = Random.Range(0, 2);
        //Debug.Log(i);
        if ( i == 1)
        {
            
            ObstacleServer.Instance.Spawn(spawner, transform.position);
        }
        
    }

}
