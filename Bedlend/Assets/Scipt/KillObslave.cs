using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillObslave : MonoBehaviour
{
   
   
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.GetComponent<Player2>() != null)
        {
            Debug.Log("Game Over");
            GameOver.Instance.Gameover();
        }
    }

}
