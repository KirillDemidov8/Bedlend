
using UnityEngine;

public class CameraCotroler : MonoBehaviour
{
    private float speed = 0.02f;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        CameraMove();
    }

    public void CameraMove()
    {
        transform.Translate(Vector3.right * speed);
    }
}
