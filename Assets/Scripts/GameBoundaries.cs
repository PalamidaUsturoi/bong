using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundaries : MonoBehaviour
{
    public Action<Collision2D> OnCollision;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (OnCollision != null)
            OnCollision.Invoke(col);
    }
}
