using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DoctorMovement : MonoBehaviour
{
    public float speed = 5f;
    private string direction;
    private string distance;
    private string target;
    public Transform PlayerOneTransform;
    public Transform PlayerTwoTransform;
    private bool playerOneCollision = false;
    private bool playerTwoCollision = false;
    private Animator animator;
    private string victim;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void DocDirection(int PlayerOneX, int PlayerOneY, int PlayerTwoX, int PlayerTwoY)
    {
        if ((PlayerOneX * PlayerOneX + PlayerOneY * PlayerOneY) < (PlayerTwoX * PlayerTwoX + PlayerTwoY + PlayerTwoY)) // player one is closer
        {
            victim = "PlayerOne";
        }
        else
        {
            victim = "PlayerTwo";
        }
    }

    public void DocMoving(int PlayerOneX, int PlayerOneY, int PlayerTwoX, int PlayerTwoY)
    {
        // finding closest direction using pythagorean theorem
        if (victim == "PlayerOne") // player one is closer
        {
            if (PlayerOneX != 0)
            {
                this.target = "PlayerOneX";
                this.distance = PlayerOneX.ToString();
            }
            else
            {
                this.target = "PlayerOneY";
                this.distance = PlayerOneY.ToString();
            }
        }
        else
        {
            if (PlayerTwoX != 0)
            {
                this.target = "PlayerTwoX";
                this.distance = PlayerTwoX.ToString();
            }
            else
            {
                this.target = "PlayerTwoY";
                this.distance = PlayerTwoY.ToString();
            }
        }

        // pointing doctor in the correct direction
        if (this.target == "PlayerOneY" || this.target == "PlayerTwoY")
        {
            if ((int.Parse(this.distance) - transform.position.y) < 0)
            {
                this.direction = "Down";
                animator.SetInteger("direction", 0);
            }
            else if ((int.Parse(this.distance) - transform.position.y) > 0)
            {
                this.direction = "Up";
                animator.SetInteger("direction", 1);
            }
        }

        if (this.target == "PlayerOneX" || this.target == "PlayerTwoX")
        {
            if ((int.Parse(this.distance) - transform.position.x) < 0)
            {
                this.direction = "Left";
                animator.SetInteger("direction", 2);
            }
            else if ((int.Parse(this.distance) - transform.position.x) > 0)
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

        if (!playerOneCollision && !playerTwoCollision){  
            DocDirection(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY);
        }
        DocMoving(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY);
    }
}