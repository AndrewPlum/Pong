using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball_movement : MonoBehaviour
{
   [SerializeField] bool down;
   [SerializeField] bool up;
   [SerializeField] bool left;
   [SerializeField] bool right;
   [SerializeField] float speed = 1f;
   
   private Vector3 velocity;

   private void Update()
   {
      UpdateVelocity();
      transform.position += velocity * Time.deltaTime;
   }

   private void UpdateVelocity()
   {
      if(right && up)
      {
         velocity = new Vector3(1f, 1f, 0) * speed;
      }
      else if(right && down)
      {
         velocity = new Vector3(1f, -1f, 0) * speed;
      }
      else if(left && up)
      {
         velocity = new Vector3(-1f, 1f, 0) * speed;
      }
      else if(left && down)
      {
         velocity = new Vector3(-1f, -1f, 0) * speed;
      }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      string wall = collision.gameObject.name;
      string player = collision.gameObject.name;

      if(wall == "top_wall" && right && up)
      {
         up = false; down = true; right = true; left = false;
      }
      else if(wall == "top_wall" && left && up)
      {
         up = false; down = true; right = false; left = true;
      }
      else if(wall == "bottom_wall" && right && down)
      {
         up = true; down = false; right = true; left = false;         
      }
      else if(wall == "bottom_wall" && left && down)
      {
         up = true; down = false; right = false; left = true;
      }
      else if(wall == "player2" && right && up)
      {
         up = true; down = false; right = false; left = true;
      }
      else if(wall == "player2" && right && down)
      {
         up = false; down = true; right = false; left = true;
      }
      else if(wall == "player1" && left && up)
      {
         up = true; down = false; right = true; left = false;
      }
      else if(wall == "player1" && left && down)
      {
         up = false; down = true; right = true; left = false;
      }
      else if(wall == "left_wall" || wall == "right_wall")
      {
         transform.position = new Vector3(0, 0, 0);
      }
   }
}
