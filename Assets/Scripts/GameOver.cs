using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScene;
    public GameObject restartButton;

    public List<int> maxScore;
    int i = 0;

    public Text scoreTextDisplay;
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
        gameOverScene.SetActive(false);
        restartButton.SetActive(false);
    }
}
