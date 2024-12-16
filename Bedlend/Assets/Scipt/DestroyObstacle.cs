using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player2>() != null)
        {
            ObstacleServer.Instance.OffCollisionOpstate(gameObject);
        }
        
    }
}
