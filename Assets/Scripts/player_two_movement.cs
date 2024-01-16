using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_two_movement : MonoBehaviour
{
   private Rigidbody2D rb;
   private Vector2 velocityUp;
   private Vector2 velocityDown;
   private string collided_object = "init";

   // Start is called before the first frame update
   void Start()
   {
      rb = GetComponent<Rigidbody2D>(); // rigidbody
      velocityUp = new Vector2(0f, 5f); // velocity up
      velocityDown = new Vector2(0f, -5f); // velocity down
   }

   private void FixedUpdate()
   {
      movement();
   }

   private void movement()
   {
      // move up
      if(Input.GetKey(KeyCode.UpArrow))
      {
         //Debug.Log("pressing UpArrow");
         if(collided_object == "bottom_wall")
         {
            collided_object = "none";
         }
         if(collided_object == "top_wall")
         {
            //rb.MovePosition(rb.position + Vector2(0f, 0f) * Time.fixedDeltaTime);   
            Debug.Log(collided_object);
         }
         else
         {
            rb.MovePosition(rb.position + velocityUp * Time.fixedDeltaTime);
         }
      }
      // move down
      else if(Input.GetKey(KeyCode.DownArrow))
      {
         //Debug.Log("pressing DownArrow");
         if(collided_object == "top_wall")
         {
            collided_object = "none";
         }
         if(collided_object == "bottom_wall")
         {
            //rb.MovePosition(rb.position + Vector2(0f, 0f) * Time.fixedDeltaTime);   
            Debug.Log(collided_object);
         }
         else
         {
            rb.MovePosition(rb.position + velocityDown * Time.fixedDeltaTime);
         }
      }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      collided_object = collision.gameObject.name;
      //Debug.Log(collided_object);
   }
}
