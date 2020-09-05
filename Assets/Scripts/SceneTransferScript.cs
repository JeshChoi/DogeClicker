using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneTransferScript : MonoBehaviour
{
   public void GoToPlayScene()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToShop()
    {
        SceneManager.LoadScene(3);
    }
    public static void GoToDeathScene()
    {
        SceneManager.LoadScene(2);
    }
    public void RestartGameScene()
    {
        SceneManager.LoadScene(0);
    }
}
