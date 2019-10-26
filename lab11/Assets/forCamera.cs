using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCamera : MonoBehaviour
{
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float senseHor = 9.0f;
    public float senseVer = 9.0f;
    public float MaxVer = 45.0f;
    public float MinVer = -45.0f;
    private float _rotationX = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * senseHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * senseVer;
            _rotationX = Mathf.Clamp(_rotationX, MinVer, MaxVer);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.5f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
        }
    }
}
