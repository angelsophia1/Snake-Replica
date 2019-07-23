using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;
    private void Start()
    {
        isGameOver = false;
    }
    public void restartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
