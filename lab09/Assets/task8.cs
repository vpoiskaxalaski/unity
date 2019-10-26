using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task8 : MonoBehaviour
{
    MeshRenderer render;
    float minX;
    float maxX;
    float minZ;
    float maxZ;
    float newX;
    float newZ;
    float newY;


    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;
    }

    // Update is called once per frame
    void Update()
    {
        newX = Random.Range(minX, maxX);
        newZ = Random.Range(minZ, maxZ);

        newY = transform.position.y + 5;

        if(Input.GetMouseButtonDown(0))
        {
            GameObject cubb = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubb.transform.position = new Vector3(newX, newY, newZ);

            cubb.AddComponent<Rigidbody>();
        }
    }
}
