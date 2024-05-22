using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject restartButton;

    public void Restart()
    {
        //Time.timeScale = 1;
        restartButton.SetActive(false);
    }
}
