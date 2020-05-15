using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaphaelEnemy: MonoBehaviour
{
    public GameObject enemyRaphaelBullet;
    int hitpoints;
    float shootWait;
    float shootDelay;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 100;
        shootDelay = 3.0f;
        shootWait = 0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        transform.position = transform.position + transform.forward * 0.05f;
        shootWait += Time.deltaTime;
        if (shootWait > shootDelay)
        {
            Instantiate(enemyRaphaelBullet, transform.position + 2 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
    }
}
