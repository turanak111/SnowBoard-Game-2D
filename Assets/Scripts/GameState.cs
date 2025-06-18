using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameState : MonoBehaviour
{
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
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.tag == "Finish")
        {
            Debug.Log("you win");
            SceneManager.LoadScene("SampleScene");
        }



    }
    void LoadSceneAgain()
    {
        
    }
  
}
