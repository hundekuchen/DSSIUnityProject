using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int hitpoints;
    public float speed;
    public float armor;
    public float shootCooldown;
    public float bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        //speed = 10f;
        //armor = 10f;
        //hitpoints = 1000;
    }

    public void setData(int hp, float s, float a)
    {
        hitpoints = hp;
        speed = s;
        armor = a;
    }

    public float getSpeed()
    {
        return speed;
    }

    // Update is called once per frame
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
