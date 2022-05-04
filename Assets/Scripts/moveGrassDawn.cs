using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGrassDawn : MonoBehaviour
{
    [SerializeField] public float moveSpeed = -2f;
    private Vector3 moveGrass;
    // Start is called before the first frame update
    private void Awake()
    {
        moveGrass = new Vector3(0f, moveSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveGrass * Time.deltaTime);
    }
}
