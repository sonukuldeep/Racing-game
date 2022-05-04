using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ememyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "enemyCar" || collision.gameObject.tag == "tree")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "grass")
        {
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
