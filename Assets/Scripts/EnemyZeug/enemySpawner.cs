using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;

    float spawnDelay;
    float spawnWait;
    int hitpoints;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = 10f;
        spawnWait = 0.0f;
        hitpoints = 500;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnWait > spawnDelay)
        {
            Instantiate(enemy, transform.position - 2 * transform.forward, transform.rotation);
            spawnWait = 0f;

            if (spawnDelay >= 3)
            {
                spawnDelay -= 0.5f;
            }

            Debug.Log("Spawndelay: " + spawnDelay);

        }

        spawnWait += Time.deltaTime;

    }

    public void takeDamage(int damage)
    {
        hitpoints -= damage;
        Debug.Log("Spawner Hitpoints = " + hitpoints);
        if (hitpoints < 0)
        {
            Destroy(gameObject);
        }
    }
}
