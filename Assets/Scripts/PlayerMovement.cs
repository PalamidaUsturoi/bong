using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
}
