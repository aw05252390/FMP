using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 20;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey("d"))
        {
            pos.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= Speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            pos.y += Speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= Speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}