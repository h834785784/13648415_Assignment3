using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Exit : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
