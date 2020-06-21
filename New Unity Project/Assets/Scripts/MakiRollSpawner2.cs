using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner2 : MonoBehaviour
{
        //ogni quanto spawnano
    //public float repeatSpawnRate;
        //dopo quanto spawnano per la prima volta
    //public GameObject[] makiRolls;
    public float spawnDelay;
    public int makiRollsN;
    public float maxMakiRolls;

    public GameObject makiRoll1;
    //public int x;
    //public int y;
    public Transform spawnPoint;
    private Vector3 spawnPointV;
    //collider per contare i makirolls passati
    public Collider2D makiCC;

    //void Awake()
    //{
    //    makiRolls = GameObject.FindGameObjectsWithTag("Makiroll");
    //    int makiRollsN = GameObject.FindGameObjectsWithTag("Makiroll").Length;
    //    //InvokeRepeating("Spawning", spawnDelay, repeatSpawnRate);
    //}

    private void Start()
    {
        StartCoroutine("SpawnMakiRolls");
        spawnPointV = spawnPoint.position;
    }

    void Spawning()
    {    
        Instantiate(makiRoll1, spawnPointV, Quaternion.identity);
    }

    //test, spawna, aspetta, spawna, resetta coroutine (in update, quando i maki roll sono X stoppa la coroutine
    IEnumerator SpawnMakiRolls()
    {
        if(makiRollsN < maxMakiRolls)
        {
            Spawning();
            yield return new WaitForSeconds(spawnDelay);
            yield return SpawnMakiRolls();
        }
        yield return null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.tag = "Makiroll";
        makiRollsN += 1;
        //Debug.Log("passati " + makiRollsN + " maki rollsss");        
    }
}
