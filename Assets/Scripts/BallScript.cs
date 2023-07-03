using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 0.03f;
    public int sens = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sens = ResetBall();
    }

    public int ResetBall()
    {
        transform.position = Vector3.zero;
        int sensx = Random.Range(0, 2);
        int sens = sensx + 1;
        sensx -= (1 - sensx % 2);
        int sensy = Random.Range(0, 2);
        sensy -= (1 - sensy % 2);
        float coefy = Random.Range(0.3f, 0.5f);
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(speed * sensx, speed * sensy * coefy, 0.0f));
        return sens;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
