using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public int Turret;
    // Start is called before the first frame update
    void Start()
    {
        Turret = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Turret <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == ("Bullet(Clone)"))
        {
            Turret -= 1;
        }
    }
}
