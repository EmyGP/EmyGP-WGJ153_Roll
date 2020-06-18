using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner2 : MonoBehaviour
{
    public GameObject makiRoll1;
        //ogni quanto spawnano
    public float timeIntervals;
        //quanti spawn voglio avere
    public float maxSpawn;
    public int x;
    public int y;
    public GameObject[] makiRolls;
    private int makiRollsN;

    void Awake()
    {
        //mT = timeIntervals * maxSpawn;
        makiRolls = GameObject.FindGameObjectsWithTag("Makiroll");
        int makiRollsN = GameObject.FindGameObjectsWithTag("Makiroll").Length;
        InvokeRepeating("Spawning", maxSpawn, timeIntervals);
    }

    private void Start()
    {
    }

    void Spawning()
    {    
        Instantiate(makiRolls[makiRollsN], new Vector3(x, y, 0), Quaternion.identity);
        Debug.Log("ehiiiiiiiiiiiiiiiii");
    }

    private void Update()
    {
        if (makiRollsN <= 0)
        {
            //ferma lo spawn dei maki rolls
        }
        
    }
}
