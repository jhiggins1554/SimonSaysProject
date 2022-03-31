using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public void BackToMenu(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
