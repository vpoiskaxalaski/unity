using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCube : MonoBehaviour
{
    int count;
    public Color[] colors = { Color.black, Color.blue, Color.cyan, Color.gray, Color.green, Color.grey, Color.magenta, Color.red, Color.yellow, Color.white };
    // Start is called before the first frame update
    void Start()
    {
        count = colors.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown()
    {
        if(count < 0)
        {
            count = colors.Length-1;
        }
        
        gameObject.GetComponent<Renderer>().material.color = colors[count];
        gameObject.GetComponent<Rigidbody>().AddForce(0, 300, 0);
        count = count - 1;

    }

}