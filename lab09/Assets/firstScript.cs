using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    public float speed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        transform.position = player.transform.position - Vector3.forward * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        transform.position = new Vector3(posX + speed * Time.deltaTime, posY, posZ);
    }
}
