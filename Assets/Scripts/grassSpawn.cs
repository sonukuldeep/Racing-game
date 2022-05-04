using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassSpawn : MonoBehaviour
{

    [SerializeField] public GameObject grassPrefab;
    [SerializeField] public GameObject treePrefab;
    [SerializeField] public Vector3 spawnPositon = new Vector3(-31.5f, 0, 0);
    private GameObject grass;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 treeUpright = new Vector3(180, 0, 0);
        
        //parent spawn
        grass = Instantiate(grassPrefab,spawnPositon,Quaternion.identity);
        //kids spawn
        GameObject tree1 = Instantiate(treePrefab, spawnPositon, Quaternion.Euler(treeUpright));
        tree1.transform.parent = grass.gameObject.transform;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
