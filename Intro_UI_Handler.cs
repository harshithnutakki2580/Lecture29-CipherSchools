using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_UI_Handler : MonoBehaviour
{
   public GameObject instructionPanel;

   public void ToggleInstructionPanel(int toggle)
   {
        if(toggle == 1)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            instructionPanel.SetActive(true);
        }
   }

   public void ChangesCurrentScene()
   {
        Scene CurrentScene = SceneManager.GetActiveScene();

        int nextIndex = CurrentScene.buildIndex +1;

        SceneManager.LoadScene(nextIndex);
   }
}
