using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControler : MonoBehaviour
{
    [SerializeField] private  GameObject[] prefabRoom;
   
    int x = 18;
    
    void Start()
    {
        SpawnRoom();
    }

    private void SpawnRoom()
    {
        for(int i = 0; i < 6; i++)
        {
            int y = Random.Range(0, 4);
            if (i != 5)
            {


                Instantiate(prefabRoom[y], new Vector3(x, 0, 0), Quaternion.identity);
                x += 18;
            }
            else
            {
                Instantiate(prefabRoom[5], new Vector3(x, 0, 0), Quaternion.identity);
               
            }
            
                
            
            
           
        }
        
    }

}
