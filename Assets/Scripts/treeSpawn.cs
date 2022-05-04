using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawn : MonoBehaviour
{
    [SerializeField] public GameObject[] trees;
    [SerializeField] public float maxPostion,minPosition;
    [SerializeField] public float delayTimer;
    float timer;
    int treeNumber;
    private Vector3 treeRotation;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
        treeRotation = new Vector3(180, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(minPosition, maxPostion), transform.position.y, 0);
            treeNumber = Random.Range(0, trees.Length);
            Instantiate(trees[treeNumber], carPos, Quaternion.Euler(treeRotation.x,0,0));
            timer = delayTimer;
            //Debug.Log(carPos);
        }
    }
}
