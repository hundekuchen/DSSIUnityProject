using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehave : MonoBehaviour
{

    float moveSpeed;
    float turnSpeed;
    float distDeltatSpur;
    float distFromSpur;

    public GameObject panzerSpuren;

    // Start is called before the first frame update
    void Start()
    {
        distDeltatSpur = 0.1f;
        moveSpeed = 0.05f;
        turnSpeed = 3f;
        distFromSpur = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float turn = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");

        //move forward/backward
        Vector3 moveVector = transform.forward * moveSpeed * move;
        transform.position = transform.position + moveVector;
        distFromSpur += moveSpeed * move;

        //turn left right
        transform.Rotate(0.0f, turn * turnSpeed, 0.0f);

        //spuren
        if (distFromSpur > distDeltatSpur)
        {
            Instantiate(panzerSpuren, transform.position - 1 * transform.forward, transform.rotation);
            distFromSpur = 0f;
        }
    }
}