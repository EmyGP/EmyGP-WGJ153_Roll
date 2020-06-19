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
    public int x;
    public int y;
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
    }

    void Spawning()
    {    
        Instantiate(makiRoll1, new Vector3(x, y, 0), Quaternion.identity);
    }

    //test, spawna, aspetta, spawna, resetta coroutine (in update, quando i maki roll sono X stoppa la coroutine
    IEnumerator SpawnMakiRolls()
    {
        yield return new WaitForSeconds(spawnDelay);
        Spawning();
        yield return SpawnMakiRolls();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.tag = "Makiroll";
        makiRollsN += 1;
        Debug.Log("passati " + makiRollsN + " maki rollsss");        
    }

    private void Update()
    {
        if (makiRollsN >= maxMakiRolls)
        {
            StopCoroutine(SpawnMakiRolls());
            Debug.Log("STOP");
            //ferma lo spawn dei maki rolls
            //come? il counter makirollsN conta quanti maki passano per un collider. Quando sono >= fermo la coroutine che farò
        }
        else { };
    }
}
