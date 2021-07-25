using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //camera movement
    public float _horizontalSpeed;
    public float _verticalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
  
            float h = _horizontalSpeed * Input.GetAxis("Mouse X");
            float v = _verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(v, h, 0); 
            
    }
}
