using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DocMovement : MonoBehaviour
{
    private Animator animator;
    public float speed = 5f;
    public int OneDistanceX; // distance from player 1 on x axis
    public int OneDistanceY; // distance from player 1 on y axis
    public int TwoDistanceX; // distance from player 2 on x axis
    public int TwoDistanceY; // distance from player 2 on y axis
    public string Target; // the player that the doctor is chasing
    public int TargetDistanceX; // distance from target on x axis
    public int TargetDistanceY; // distance from target on y axis
    public Transform PlayerOneTransform;
    public Transform PlayerTwoTransform;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void DocMove(int PlayerOneX, int PlayerOneY, int PlayerTwoX, int PlayerTwoY)
    {
        OneDistanceX = Mathf.RoundToInt(transform.position.x) - PlayerOneX;
        OneDistanceY = Mathf.RoundToInt(transform.position.y) - PlayerOneY;
        TwoDistanceX = Mathf.RoundToInt(transform.position.x) - PlayerTwoX;
        TwoDistanceY = Mathf.RoundToInt(transform.position.y) - PlayerTwoY;

        // finding closest person
        if ((OneDistanceX * OneDistanceX + OneDistanceY * OneDistanceY) < (TwoDistanceX * TwoDistanceX + TwoDistanceY * TwoDistanceY))
        {
            Target = "PlayerOne";
            TargetDistanceX = OneDistanceX;
            TargetDistanceY = OneDistanceY;
        }
        else
        {
            Target = "PlayerTwo";
            TargetDistanceX = TwoDistanceX;
            TargetDistanceY = TwoDistanceY;
        }

        // which direction to move
        Vector2 movementDirection = Vector2.zero;

        if (Mathf.Abs(TargetDistanceX) > Mathf.Abs(TargetDistanceY))
        {
            // move towards player along x axis
            if (TargetDistanceX > 0)
            {
                movementDirection = Vector2.left;
                animator.SetInteger("direction", 2);
            }
            else if (TargetDistanceX < 0)
            {
                movementDirection = Vector2.right;
                animator.SetInteger("direction", 3);
            }
        }
        else
        {
            // move towards player along y axis
            if (TargetDistanceY > 0)
            {
                movementDirection = Vector2.down;
                animator.SetInteger("direction", 0);
            }
            else if (TargetDistanceY < 0)
            {
                movementDirection = Vector2.up;
                animator.SetInteger("direction", 1);
            }
        }

        // move the doctor towards player on the selected axis
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player 1" || collision.gameObject.tag == "Player 2")
        {
            SceneManager.LoadScene("PlayerDied");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int PlayerOneX = (int)PlayerOneTransform.position.x;
        int PlayerOneY = (int)PlayerOneTransform.position.y;
        int PlayerTwoX = (int)PlayerTwoTransform.position.x;
        int PlayerTwoY = (int)PlayerTwoTransform.position.y;

        DocMove(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY);
    }
    
}
