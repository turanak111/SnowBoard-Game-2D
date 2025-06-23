using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;    
    [SerializeField] float torqueamount;
    void Start()
    {
         rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddTorque(torqueamount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddTorque(-torqueamount);
        }
    }
}
