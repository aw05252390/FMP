using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevels : MonoBehaviour
{
    public int randomIndex;
    public int randomIndex2;
    public int randomIndex3;
    public int randomIndex4;



    // Start is called before the first frame update
    void Start()
    {
        randomIndex = Random.Range(0, 4);
        randomIndex2 = Random.Range(0, 4);
        randomIndex3 = Random.Range(0, 4);
        randomIndex4 = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (randomIndex == 0)
        {
            GameObject.Find("Level11").transform.position = new Vector2(0, 0);
        }
        if (randomIndex == 1)
        {
            GameObject.Find("Level12").transform.position = new Vector2(0, 0);
        }
        if (randomIndex == 2)
        {
            GameObject.Find("Level13").transform.position = new Vector2(0, 0);
        }
        if (randomIndex == 3)
        {
            GameObject.Find("Level14").transform.position = new Vector2(0, 0);
        }
        if (randomIndex2 == 0)
        {
            GameObject.Find("Level21").transform.position = new Vector2(30, 0);
        }
        if (randomIndex2 == 1)
        {
            GameObject.Find("Level22").transform.position = new Vector2(30, 0);
        }
        if (randomIndex2 == 2)
        {
            GameObject.Find("Level23").transform.position = new Vector2(30, 0);
        }
        if (randomIndex2 == 3)
        {
            GameObject.Find("Level24").transform.position = new Vector2(30, 0);
        }
        if (randomIndex3 == 0)
        {
            GameObject.Find("Level31").transform.position = new Vector2(60, 0);
        }
        if (randomIndex3 == 1)
        {
            GameObject.Find("Level32").transform.position = new Vector2(60, 0);
        }
        if (randomIndex3 == 2)
        {
            GameObject.Find("Level33").transform.position = new Vector2(60, 0);
        }
        if (randomIndex3 == 3)
        {
            GameObject.Find("Level34").transform.position = new Vector2(60, 0);
        }
        if (randomIndex4 == 0)
        {
            GameObject.Find("Level41").transform.position = new Vector2(100, 0);
        }
        if (randomIndex4 == 1)
        {
            GameObject.Find("Level42").transform.position = new Vector2(100, 0);
        }
        if (randomIndex4 == 2)
        {
            GameObject.Find("Level43").transform.position = new Vector2(100, 0);
        }
        if (randomIndex4 == 3)
        {
            GameObject.Find("Level44").transform.position = new Vector2(100, 0);
            
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Door12")
        {
            transform.position = new Vector2(30, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(30, 0, -10);
        }
        if (other.name == "Door23")
        {
            transform.position = new Vector2(60, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(60, 0, -10);
        }
        if (other.name == "Door34")
        {
            transform.position = new Vector2(100, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(100, 0, -10);
        }
        if (other.name == "Door43")
        {
            transform.position = new Vector2(60, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(60, 0, -10);
        }
        if (other.name == "Door32")
        {
            transform.position = new Vector2(30, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(30, 0, -10);
        }
        if (other.name == "Door21")
        {
            transform.position = new Vector2(0, 0);
            GameObject.Find("Main Camera").transform.position = new Vector3(0, 0, -10);
        }
    }
}

   