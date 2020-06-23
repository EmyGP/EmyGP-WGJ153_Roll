using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner2 : MonoBehaviour
{
    //public float repeatSpawnRate;
    //public GameObject[] makiRolls;
    public float spawnDelay;
        //numero di makirolls in scena, si aggiorna in OnTrigggerEnter
    public int makiRollsN;
        //numero massimo di makiroll che voglio siano spawnati dallo spawner
    public float maxMakiRolls;

        //roba per lo spawnpoint
    public GameObject makiRoll1;
    public Transform spawnPoint;
    private Vector3 spawnPointV;
    //collider per contare i makirolls passati
    public Collider2D makiCC;

    public ScoreCounter _scoreCounter;

    //void Awake()
    //{
    //    makiRolls = GameObject.FindGameObjectsWithTag("Makiroll");
    //    int makiRollsN = GameObject.FindGameObjectsWithTag("Makiroll").Length;
    //    //InvokeRepeating("Spawning", spawnDelay, repeatSpawnRate);
    //}

    private void Start()
    {
        spawnPointV = spawnPoint.position;
        StartCoroutine("SpawnMakiRolls");
    }

    void Spawning()
    {    
        Instantiate(makiRoll1, spawnPointV, Quaternion.identity);
    }

    //se il numero di maki roll in scena < del N mi maki roll max prefissato, spawna, poi aspetta, poi se ecc. ecc. spawna di nuovo
    IEnumerator SpawnMakiRolls()
    {
        if(makiRollsN < maxMakiRolls)
        {
            Spawning();
            yield return new WaitForSeconds(spawnDelay);
            yield return SpawnMakiRolls();
        }
        else if(makiRollsN == maxMakiRolls)
        {
            //questo tempo deve essere alto per evitare che lo score guadagni un +1 a caso (vedi commento in ScoreCount.CS)
            yield return new WaitForSeconds(3.5f);
            _scoreCounter.ScoreCount();
        }
        yield return null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Makiroll")
        {
            makiRollsN += 1;
            //Debug.Log("passati " + makiRollsN + " maki rollsss");
        }
    }
}
