using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner2 : MonoBehaviour
{
    public GameObject makiRoll1;
    public int timeIntervals;
    public int x;
    public int y;

    void Start() { }

    IEnumerator SpawnTimer()
    {
        for (; ; )
        {
            Spawning();
            yield return new WaitForSeconds(timeIntervals);
        }
    }

    void Spawning()
    {
         Instantiate(makiRoll1, new Vector3(x, y, 0), Quaternion.identity);
    }
}
