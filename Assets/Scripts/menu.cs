using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
   [SerializeField] private Button resetButton;
   private bool isResetButtonActive = false;

   // Update is called once per frame
   void Update()
   {
      if(Input.GetKeyDown(KeyCode.Escape) && isResetButtonActive == false)
      {
         Time.timeScale = 0f;
         resetButton.gameObject.SetActive(true);
         isResetButtonActive = resetButton.gameObject.activeSelf;
         Debug.Log(isResetButtonActive);
      }
      else if(Input.GetKeyDown(KeyCode.Escape) && isResetButtonActive == true)
      {
         resetButton.gameObject.SetActive(false);
         isResetButtonActive = resetButton.gameObject.activeSelf;
         Time.timeScale = 1f;
         Debug.Log(isResetButtonActive);
      }
   }

   public void ReloadLevel()
   {
      resetButton.gameObject.SetActive(false);
      SceneManager.LoadScene(0);
      Time.timeScale = 1f;
   }
}
