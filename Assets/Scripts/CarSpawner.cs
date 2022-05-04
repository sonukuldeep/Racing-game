using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] cars;
    [SerializeField] public float maxPostion;
    [SerializeField] public float delayTimer;
    float timer;
    int carNumber;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-maxPostion, maxPostion), transform.position.y, transform.position.z);
            carNumber = Random.Range(0, cars.Length);
            Instantiate(cars[carNumber], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
