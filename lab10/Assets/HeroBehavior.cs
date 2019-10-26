using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
            
        }
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "green")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "red")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "blue")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0,200,0);
        }
    }
}
