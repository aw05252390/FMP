using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bulletShoot : MonoBehaviour
{
    public float Timer;
    public Transform TurretfirePoint;
    public GameObject TurretbulletPrefab;

    public float bulletForce;
    // Start is called before the first frame update

    void Start()
    {
        Timer = 2;
    }

    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        if (Timer < 0)
        {
            Shoot();
            Timer = 2;
        }

    }
    void Shoot()
    {
        GameObject bullet = Instantiate(TurretbulletPrefab, TurretfirePoint.position, TurretfirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
       // rb.AddForce(TurretfirePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}


