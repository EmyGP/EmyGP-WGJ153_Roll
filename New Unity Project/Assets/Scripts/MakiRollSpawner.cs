using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner : MonoBehaviour
{
    public GameObject makiRoll1;
    public Vector3 spawnPoint;

    void Start()
    {
        Instantiate(makiRoll1, spawnPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
