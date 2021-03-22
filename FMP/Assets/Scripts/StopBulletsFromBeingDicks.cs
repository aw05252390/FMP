using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBulletsFromBeingDicks : MonoBehaviour
{
    public GameObject hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Wall")
        {
           
            Destroy(gameObject);
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);





        }
    }
}
