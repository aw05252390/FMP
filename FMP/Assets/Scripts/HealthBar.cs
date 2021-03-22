using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Canvas HealthBarCanvas;
    public Canvas DeathCanvas;
    public Image Health;
    public Sprite hp100;
    public Sprite hp75;
    public Sprite hp50;
    public Sprite hp25;

    public int HealthAmount;

    // Start is called before the first frame update
    void Start()
    {
        HealthAmount = 100;
        HealthBarCanvas.enabled = true;
        DeathCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthAmount == 100)
        {
            Health.sprite = hp100;
        }
        if (HealthAmount == 75)
        {
            Health.sprite = hp75;
        }
        if (HealthAmount == 50)
        {
            Health.sprite = hp50;
        }
        if (HealthAmount == 25)
        {
            Health.sprite = hp25;
        }
        if (HealthAmount == 0)
        {
            HealthBarCanvas.enabled = false;
            DeathCanvas.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "TakeDamage")
        {
            HealthAmount -= 25;
            Destroy(other.gameObject);
            if (other.name == "Pit")
            {
                HealthAmount = 0;
            }
        }
    }
}
