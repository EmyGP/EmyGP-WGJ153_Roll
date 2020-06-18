using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//da mettere nel prefab del block 
public class blockBehavior2 : MonoBehaviour
{
    private GameObject block;
    private bool mouseIsDragging = false;
    public int rotDegrees = 0;
    public int rotDegreesIncr = 0;
        // se metto il rb, settarlo come kinematic
    //private Rigidbody2D blockrb;

    void Start()
    {
        block = this.gameObject;
        //blockrb = block.GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        mouseIsDragging = true;
        //block.GetComponent<BoxCollider2D>().enabled = false;
        //block.transform.Rotate(0, 0, rotDegrees);
        block.transform.rotation = Quaternion.Euler(0, 0, rotDegrees);
        rotDegrees += rotDegreesIncr;
        Debug.Log("giraaaaaaaaaaa");
        if (rotDegrees >= 180)
        {
            rotDegrees = 0;
        }
    }

    private void OnMouseUp()
    {
        mouseIsDragging = false;
        //block.GetComponent<BoxCollider2D>().enabled = true;
    }

    //click destro, ruoto object di rotDegrees gradi
    private void BlocksRotation()
    {
    }


    private void Update() { }

}
