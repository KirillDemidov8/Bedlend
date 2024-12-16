using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class YouWIn : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Player2>() != null)
        {
            Debug.Log(555);
            WinnPanell.Instance.WinPanell();
        }
    }
}
