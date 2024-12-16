using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObslaveTernOnOf : MonoBehaviour
{
   
    void Start()
    {
        TerbOffOn();
    }

    public void TerbOffOn()
    {
        int x = Random.Range(1, 3);
        Debug.Log(x);
        if (x == 1)
        {
            gameObject.SetActive(false);
        }
        
    }
}
