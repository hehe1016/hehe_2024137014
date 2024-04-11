using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    public void GoToShootGame()
    {
        SceneManager.LoadScene("GameSecne_Gun");
    }

 
    public void GoToJumpGame()
    {
        SceneManager.LoadScene("GameSecne_Jump");
    }

    public void GoExit()
    {
        Application.Quit();
    }
}
