using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarControl : MonoBehaviour
{
    [SerializeField] public float carSpeed;
    [SerializeField] public float minPos, maxPos;
    
    private float userInput;
    private Vector2 position;


    private void Start()
    {
        position = transform.position;
   
    }


    private void Update()
    {
        
        userInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        position.x += userInput * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, minPos, maxPos);
        transform.position = position;
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemyCar")
        {
            Destroy(gameObject);
        }
    }
}
