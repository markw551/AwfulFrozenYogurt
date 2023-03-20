using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMovement : MonoBehaviour{
    public class Doctor : MonoBehaviour{
        

        // doctor moving towards the player
        public DocMove(PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY){
            
            // finding closest direction
            List<int> coordinates = new List<int> {PlayerOneX, PlayerOneY, PlayerTwoX, PlayerTwoY};
            
            // finding smallest non zero number
            coordinates.Sort();
            if (PlayerOneX = coordinates.Min

            if (DocMove.direction = "Up"){
                transform.Translate(Vector2.up * speed * Time.deltaTime)
            }
            if (DocMove.direction = "Down"){
                transform.Translate(Vector2.down * speed * Time.deltaTime)
            }
            if (DocMove.direction = "Left"){
                transform.Translate(Vector2.left * speed * Time.deltaTime)
            }
            if (DocMove.direction = "Right"){
                transform.Translate(Vector2.right * speed * Time.deltaTime)
            }
        }
    }

        //destroys anything blocking the doctors way
        public BreakBlock(){

        }
    }
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
