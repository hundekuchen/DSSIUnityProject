using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class moveScript : MonoBehaviour
{
    float moveSpeed;
    float turnSpeed;
    float distDeltatTracks;
    float distFromTracks;

    public GameObject Tracks;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.08f;
        turnSpeed = 3f;
        distDeltatTracks = 0.1f;
        distFromTracks = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");

        //move forward/backward
        Vector3 moveVector = transform.forward * moveSpeed * move;
        transform.position = transform.position + moveVector;
        distFromTracks += moveSpeed * move;

        //turn left right
        transform.Rotate(0.0f, turn * turnSpeed, 0.0f);

        //spuren
        if (distFromTracks > distDeltatTracks)
        {
            Instantiate(Tracks, transform.position - 1 * transform.forward, transform.rotation);
            distFromTracks = 0f;
        }
    }
}
