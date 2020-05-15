using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulEnemy : MonoBehaviour
{
    public GameObject enemyBullet;
    int hitpoints;
    float shootWait;
    float shootDelay;

    // Start is called before the first frame update
    void Start()
    {
        hitpoints = 1000;
        shootDelay = 0.50f;
        shootWait = 0f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dirToPlayer = GameObject.FindGameObjectWithTag("player").transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dirToPlayer, Vector3.up);
        transform.position = transform.position + transform.forward * 0.05f;
        GetComponent<Rigidbody>().AddForce(transform.forward * 0.5f);
        shootWait += Time.deltaTime;
        if (shootWait > shootDelay)
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