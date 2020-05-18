using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulEnemy : MonoBehaviour
{
    public GameObject enemyBullet;
    float shootWait;
    float shootDelay;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<EnemyStats>().setData(1000, 1.5f, 5f); //hitpoints, armor, speed
        shootDelay = 0.50f;
        shootWait = 0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        if(Vector3.SqrMagnitude(dirToPlayer)>3f)
        {
            transform.position = transform.position + transform.forward * GetComponent<EnemyStats>().getSpeed();
            //GetComponent<Rigidbody>().AddForce(transform.forward * 0.5f);
        }
        shootWait += Time.deltaTime;
        if (shootWait > shootDelay)
        {
            Instantiate(enemyBullet, transform.position + 2 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
    }
}