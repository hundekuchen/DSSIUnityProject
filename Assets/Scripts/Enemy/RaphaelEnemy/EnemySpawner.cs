using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float spawnWait;
    float spawnDelay;
    float hitpoints;

    // Start is called before the first frame update
    void Start()
    {
        spawnWait = 0f;
        spawnDelay = 4f;

        hitpoints = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnWait > spawnDelay)
        {
            Instantiate(enemy, transform.position + 2 * transform.forward, transform.rotation);
            spawnWait = 0f;
        }

        spawnWait += Time.deltaTime;
    }

    public void takeDamage(int damage)
    {
        hitpoints -= damage;
        //Debug.Log("hitpoints = " + hitpoints);
        if (hitpoints < 0)
        {
            Destroy(gameObject);
        }
    }
}
