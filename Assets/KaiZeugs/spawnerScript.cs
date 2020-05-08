using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject Enemy;
    float spawnWait;
    float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait += Time.deltaTime;

        if (spawnWait > spawnDelay)
        {
            //Debug.Log("hello");
            Instantiate(Enemy, transform.position + transform.up, transform.rotation);
            spawnWait = 0f;

        }
    }
}
