using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 0.03f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ResetBall();
    }

    private void ResetBall()
    {
        transform.position = Vector3.zero;
        int sensx = Random.Range(-1, 1);
        sensx -= (1 - sensx % 2);
        int sensy = Random.Range(-1, 1);
        sensy -= (1 - sensy % 2);
        float coefy = Random.Range(0.5f, 0.5f);
        rb.AddForce(new Vector3(speed * sensx, speed * sensy * coefy, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
