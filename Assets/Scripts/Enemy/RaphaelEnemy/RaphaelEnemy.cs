using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaphaelEnemy: MonoBehaviour
{
    public GameObject enemyRaphaelBullet;
    float shootWait;
    float shootDelay;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EnemyStats>().setData(100, 3f, 0.1f); //hitpoints, armor, speed
        shootDelay = 3.0f;
        shootWait = 0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);

        if (Vector3.SqrMagnitude(dirToPlayer) > 100f)
        {
            transform.Translate(transform.forward * GetComponent<EnemyStats>().getSpeed() * Time.deltaTime, Space.World);
            float sp = GetComponent<EnemyStats>().getSpeed();
        }

        shootWait += Time.deltaTime;

        if (shootWait > shootDelay && Vector3.SqrMagnitude(dirToPlayer) <= 100f) 
        {
            Instantiate(enemyRaphaelBullet, transform.position + 2 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
    }
}
