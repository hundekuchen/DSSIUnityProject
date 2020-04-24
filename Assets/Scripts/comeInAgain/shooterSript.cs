using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterSript : MonoBehaviour
{
    public GameObject bullet;
    float turnSpeed;
    float shootDelay;
    float shootWait;
    float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 5.1f;
        shootDelay = 0.1f;
        shootWait = 0.0f;
        moveSpeed = 0.1f;

        Vector3 meinVector1;
        Vector3 meinVector2;
        meinVector1 = new Vector3(2, 3, 5);
        meinVector2 = new Vector3(5, 3, 5);
        Debug.Log(meinVector1 + meinVector2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float singleStep = turnSpeed * Time.deltaTime;
        Vector3 mouseScreenPos = Input.mousePosition; //has only x,y components
        mouseScreenPos.z = Camera.main.transform.position.y - transform.position.y;  //distance from Camera to player
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos); //convert mouseSreenPos from 2D to 3D with the missing z component to distance from Camera
        Vector3 dir = mouseWorldPos - transform.position; //direction from player to  mouseWorldPosition
        Vector3 turn = Vector3.RotateTowards(transform.forward, dir, singleStep, 0.0f); //calc next step towards diretion of mouseWorldPosition with float speed (in rad/sek)
        turn.y = 0.0f;  //make sure the rotation stays in the x-z-plane
        transform.rotation = Quaternion.LookRotation(turn, Vector3.up); //use quaternion to update rotation towards "turn" (slow turn) or "dir" (instant turn)


        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(moveSpeed * moveX, 0.0f, moveSpeed * moveY);
        transform.position = transform.position + moveVector;


        if (Input.GetMouseButton(0) && shootWait > shootDelay)
        {
            //Debug.Log("hello");
            Instantiate(bullet, transform.position + 2 * transform.forward, transform.rotation);
            shootWait = 0f;
        }
        shootWait += Time.deltaTime;
    }
}