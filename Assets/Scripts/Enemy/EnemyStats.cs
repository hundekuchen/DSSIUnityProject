using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int initialHitpoints;
    public int remainingHitpoints;
    float newColor;

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
        newColor = 255f;
        GetComponent<Renderer>().material.color = new Color(0, 0, 0); //sets initial color to black
    }

    public void setData(int hp, float s, float a)
    {
        initialHitpoints = hp;
        remainingHitpoints = hp;
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
        remainingHitpoints -= damage;
        //Debug.Log("hitpoints = " + hitpoints);
        if (remainingHitpoints < 0)
        {
            Destroy(gameObject);
        }
        //Color change:
        newColor = (float)remainingHitpoints / (float)initialHitpoints; //newColor value goes toward 0
        GetComponent<Renderer>().material.color = new Color(1 - newColor, 0, 0); //color turning red
    }
}
