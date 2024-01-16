using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
   [SerializeField] TMP_Text playerOneScoreTMP;
   [SerializeField] TMP_Text playerTwoScoreTMP;

   int playerOneScore = 0;
   int playerTwoScore = 0;

   private void OnCollisionEnter2D(Collision2D collision)
   {
      string wall = collision.gameObject.name;

      if(wall == "right_wall")
      {
         //Debug.Log("Player 1 scores!");
         playerOneScore += 1;
         playerOneScoreTMP.SetText("Player One - " + playerOneScore.ToString());
      }
      else if(wall == "left_wall")
      {
         //Debug.Log("Player 2 scores!");
         playerTwoScore += 1;
         playerTwoScoreTMP.SetText("Player Two - " + playerTwoScore.ToString());
      }
   }
}
