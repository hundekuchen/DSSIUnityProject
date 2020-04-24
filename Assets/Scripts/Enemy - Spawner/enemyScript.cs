using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject enemyBullet;
    int hitpoints;
    float shootWait;
    float shootDelay;
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 100;
        shootDelay = 1.0f;
        shootWait = 0.0f;
        moveSpeed = 0.02f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        transform.position = transform.position + transform.forward * moveSpeed;

        if(shootWait > shootDelay)
        {
           Instantiate(enemyBullet, transform.position + 2 * transform.forward, transform.rotation);
           shootWait = 0f;
        }
        shootWait += Time.deltaTime;
    }

    public void takeDamage(int damage)
    {
        hitpoints -= damage;
        Debug.Log("Enemy Hitpoints = " + hitpoints);
        if (hitpoints < 0)
        {
            Destroy(gameObject);
        }
    }
}