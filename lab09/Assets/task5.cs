using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task5 : MonoBehaviour
{
    public float speed = 25;
    private Rigidbody rb;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rend.material.color = Color.yellow;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            rend.material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            rend.material.color = Color.red;
        }
    }
}
