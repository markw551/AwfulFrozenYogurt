using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DoctorMovement : MonoBehaviour
{
    public float speed = 5f;
    private string direction;
    private float distance;
    private string target;
    public Transform PlayerOneTransform;
    public Transform PlayerTwoTransform;
    private Animator animator;
    private string victim;
    private float XAbsDistance;
    private float YAbsDistance;
    public bool XCloseEnough;
    public bool YCloseEnough;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void DocMoving(int PlayerOneX, int PlayerOneY, int PlayerTwoX, int PlayerTwoY)
    {
        victim = "PlayerOne";
        // finding closest direction using pythagorean theorem
        //if ((PlayerOneX * PlayerOneX + PlayerOneY * PlayerOneY) < (PlayerTwoX * PlayerTwoX + PlayerTwoY * PlayerTwoY))
        //{
        //    victim = "PlayerOne";
        //}
        //else
        //{
        //    victim = "PlayerTwo";
        //}
        
        if (victim == "PlayerOne") // player one is closer
        {
            
            XAbsDistance = Math.Abs(transform.position.x) - Math.Abs(PlayerOneX);
            YAbsDistance = Math.Abs(Math.Abs(transform.position.y) - Math.Abs(PlayerOneY));

            if ( XAbsDistance < YAbsDistance && XCloseEnough == false)
            {
                this.target = "PlayerOneX";
                this.distance = transform.position.x - PlayerOneX;
                if (XAbsDistance < 0.01)
                {
                    XCloseEnough = true;
                    YCloseEnough = false;
                }
            }
            if (YCloseEnough == false)
            {
                this.target = "PlayerOneY";
                this.distance = transform.position.y - PlayerOneY;
                if (YAbsDistance < 0.01)
                {
                    YCloseEnough = true;
                    XCloseEnough = false;
                }
            }
        }
        else
        {
            
            XAbsDistance = Math.Abs(transform.position.x) - Math.Abs(PlayerTwoX);
            YAbsDistance = Math.Abs(Math.Abs(transform.position.y) - Math.Abs(PlayerTwoY));
            
            if (XAbsDistance < YAbsDistance && XAbsDistance != 0)
            {
                this.target = "PlayerTwoX";
                this.distance = transform.position.x - PlayerTwoX;
            }
            else
            {
                this.target = "PlayerTwoY";
                this.distance = transform.position.y - PlayerTwoY;
            }
        }

        // pointing doctor in the correct direction
        if (this.target == "PlayerOneY" || this.target == "PlayerTwoY")
        {
            if (this.distance > 0)
            {
                this.direction = "Down";
                animator.SetInteger("direction", 0);
            }
            else if (this.distance < 0)
            {
                this.direction = "Up";
                animator.SetInteger("direction", 1);
            }
        }

        if (this.target == "PlayerOneX" || this.target == "PlayerTwoX")
        {
            if (this.distance > 0)
            {
                this.direction = "Left";
                animator.SetInteger("direction", 2);
            }
            else if (this.distance < 0)
            {
                this.direction = "Right";
                animator.SetInteger("direction", 3);
            }
        }

        // doctor starts moving
        if (this.direction == "Up")
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (this.direction == "Down")
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if (this.direction == "Left")
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (this.direction == "Right")
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    void Update()
    {
        int PlayerOneX = (int)PlayerOneTransform.position.x - (int)transform.position.x;
        int PlayerOneY = (int)PlayerOneTransform.position.y - (int)transform.position.y;
        int PlayerTwoX = (int)PlayerTwoTransform.position.x - (int)transform.position.x;
        int PlayerTwoY = (int)PlayerTwoTransform.position.y - (int)transform.position.y;

        DocMoving(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY);
    }
}