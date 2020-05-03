using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void pressedPlay()
   {
      SceneManager.LoadScene("SampleScene");
   }

   public void pressedOptions()
   {
      SceneManager.LoadScene("Options");

   }

   public void pressedExit()
   {
      Application.Quit();
   }
}
