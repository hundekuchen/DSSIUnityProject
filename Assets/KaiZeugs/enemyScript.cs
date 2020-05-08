using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    int hitpoints;
    float shootWait;
    float shootDelay;

    public GameObject enemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 100;
        shootDelay = 1f;
        shootWait = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        transform.position = transform.position + transform.forward * 0.05f;
        shootWait += Time.deltaTime;
        if(shootWait > shootDelay)
        {
           Instantiate(enemyBullet, transform.position + 2 * transform.forward, transform.rotation);
           shootWait = 0f;
        }
    }

    public void takeDamage(int damage)
    {
        hitpoints -= damage;
        Debug.Log("hitpoints = " + hitpoints);
        if (hitpoints < 0)
        {
            Destroy(gameObject);
        }
    }
}
