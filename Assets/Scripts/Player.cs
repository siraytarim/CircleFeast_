using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float turnSpeed;

    public int health;
    int score;
 
    public TMP_Text healthDisplay;  
    public TMP_Text scoreDisplay;

    public GameObject gameOver;

    public Text scoreTextDisplay;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }

    public void TakeDamage()
    {
        health--;
        healthDisplay.text = "Health " + health;
        if(health <= 0)
        {
            //Time.timeScale = 0; //ekraný durdurdu
            gameOver.SetActive(true);
            scoreTextDisplay.text = "Your Score: " + score;
        }
    }

    public void AddScore()
    {   
        score++;
        scoreDisplay.text = "Score " + score;
    }
    

}
