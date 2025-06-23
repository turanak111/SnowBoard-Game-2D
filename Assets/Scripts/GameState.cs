using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class GameState : MonoBehaviour
{
    [SerializeField] GameObject panel;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Kar")
        {
            Debug.Log("you lose");
            Invoke("PlayerDied", 0.2f);
      

        }
        if (collision.tag == "Finish")
        {
            Debug.Log("you win");
            Invoke("EndGame", 0.2f);
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    void EndGame()
    {
        Time.timeScale = 0;
    }
    void PlayerDied()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}

