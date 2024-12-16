using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleServer : MonoBehaviour
{
    

    private static ObstacleServer instance;
    public static ObstacleServer Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ObstacleServer();
            }

            return instance;
        }
    }
    public void OffCollisionOpstate(GameObject go)
    {
        go.GetComponent<BoxCollider2D>().isTrigger = true;
        Destroy(go, 3);
    }

    public void Spawn(GameObject prefab, Vector3 pos)
    {
        Instantiate(prefab, pos, Quaternion.identity);
    }



}
