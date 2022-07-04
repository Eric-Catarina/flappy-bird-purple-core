using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCanos : MonoBehaviour
{
    public static event Action OnDeath;
    [SerializeField]
    private Rigidbody2D rb;
    
    [SerializeField]
    private float canoSpeed = 2;
    void OnCollisionEnter2D(Collision2D colisao){
        if (colisao.gameObject.name == "flappyVermelho"){
                Debug.Log("Bateu");
                OnDeath?.Invoke();
                Time.timeScale = 0f;
        }
    }
    






    void Start()
    {
        Vector2 movimentoHorizontal = new Vector2(canoSpeed*-1,0);
        rb.velocity = movimentoHorizontal;
    }   
   
   
    
    void FixedUpdate()
    {
       
    }
}
