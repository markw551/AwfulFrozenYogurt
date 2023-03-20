using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMovement : MonoBehaviour
{
    public class Doctor : MonoBehaviour
    {
        // finds which player is closest
        public DocSearch(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY)
        {
            this.PlayerOneDistance = math.sqrt(PlayerOneX * PlayerOneX + PlayerOneX * PlayerOneX)
            this.PlayerTwoDistance = math.sqrt(PlayerTwoX * PlayerTwoX + PlayerTwoY * PlayerTwoY)

            // closer to player 1 using the pythagorean theorem
            if (this.PlayerOneDistance > PlayerTwoDistance)
            {
                this.ClosestPlayer = "Player 1"
            }
            //closer to player 2
            else
            {
                this.ClosestPlayer = "Player 2"
            }
        }

        // doctor moving towards the player
        public DocMove(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY)
        {
            if (Doctor.ClosestPlayer = "Player 1")
            {
                // move in y direction
                if (math.abs(PlayerOneX) > math.abs(PlayerOneY) && PlayerOneY != 0)
                {
                    if(PlayerOneY < 0)
                    {
                        transform.Translate(Vector2.down * speed * Time.deltaTime)
                    }
                    else
                    {
                        transform.Translate(Vector2.up * speed * Time.deltatime)
                    }
                }
                else
                {
                    if(PlayerOneX < 0)
                    {
                        transform.Translate(Vector2.left * speed * Time.deltaTime)
                    }
                    else
                    {
                        transform.Translate(Vector2.right * speed 8 Time.deltaTime)
                    }
                }
            }
            else
            {

            }
        }

        //destroys anything blocking the doctors way
        public BreakBlock()
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
