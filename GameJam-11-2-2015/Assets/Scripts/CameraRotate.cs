using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float rotationspeed;
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * rotationspeed, 0);
        
    }
}
