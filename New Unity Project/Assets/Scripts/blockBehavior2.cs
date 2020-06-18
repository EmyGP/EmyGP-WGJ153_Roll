using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//da mettere nel prefab del block 
public class blockBehavior2 : MonoBehaviour
{
    private GameObject block;
    public int rotDegrees = 0;
    public int rotDegreesIncr = 0;

    void Start()
    {
        block = this.gameObject;
    }

    private void OnMouseDown()
    {
        //block.transform.Rotate(0, 0, rotDegrees);
        block.transform.rotation = Quaternion.Euler(0, 0, rotDegrees);
        rotDegrees += rotDegreesIncr;
        if (rotDegrees >= 180)
        {
            rotDegrees = 0;
        }
    }
}
