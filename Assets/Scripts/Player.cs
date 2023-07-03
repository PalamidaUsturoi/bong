using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Action<Collision2D> OnCollision;
    [SerializeField] private int player = 1;
    void Start()
    {
    
    }

    void Update()
    {
        if ( (player == 1 && Input.GetKey(KeyCode.W)) || (player == 2 && Input.GetKey(KeyCode.UpArrow)) )
        {
            transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        }
        else if ( (player == 1 && Input.GetKey(KeyCode.S)) || (player == 2 && Input.GetKey(KeyCode.DownArrow)) )
        {
            transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            if (OnCollision != null)
                OnCollision.Invoke(collision);
        }
    }
}
