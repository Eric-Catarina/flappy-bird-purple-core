using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoAve : MonoBehaviour
{
    
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    [SerializeField]
    private float forcaPulo = 10f;
    private void puloPassaro(){
    rb.velocity = new Vector2(0,forcaPulo);
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump")){
            puloPassaro();
        };
        
    }
}
