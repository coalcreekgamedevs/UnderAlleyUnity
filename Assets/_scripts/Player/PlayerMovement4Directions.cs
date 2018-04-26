using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement4Directions : MonoBehaviour 
{
        public float speed = 3f;
        private Vector2 movement;


        // Use this for initialization
        void Start()
        {
        
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float inputX = Input.GetAxisRaw("Horizontal");
            float inputY = Input.GetAxisRaw("Vertical");
            movement = new Vector2(inputX, inputY);

            //Diagonals
            /*
            if (inputX != 0 && inputY != 0)
            {
                if (movement.y == 1 && movement.x == -1)
                {
                    anim.SetTrigger("move_up_left");
                }

                if (movement.y == 1 && movement.x == 1)
                {
                    anim.SetTrigger("move_up_right");
                }

                if (movement.y == -1 && movement.x == -1)
                {
                    anim.SetTrigger("move_down_left");
                }

                if (movement.y == -1 && movement.x == 1)
                {
                    anim.SetTrigger("move_down_right");
                }
            }

            else
            {

                //left/right/up/down
                if (movement.x == -1)
                {
                    anim.SetTrigger("move_left");
                }

                if (movement.x == 1)
                {
                    anim.SetTrigger("move_right");
                }


                if (movement.y == 1)
                {
                    anim.SetTrigger("move_up");
                }


                if (movement.y == -1)
                {
                    anim.SetTrigger("move_down");
                }
            }

            */


            transform.Translate(movement * speed * Time.deltaTime);
        }


    }
 