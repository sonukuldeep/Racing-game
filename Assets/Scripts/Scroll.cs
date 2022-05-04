using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] float yVelocity;
    Material material;
    Vector2 offset;
    
    // Start is called before the first frame update

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(0, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
