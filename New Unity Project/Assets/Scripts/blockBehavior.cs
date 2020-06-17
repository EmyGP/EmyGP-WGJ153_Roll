using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//da mettere nel prefab del block 
public class blockBehavior : MonoBehaviour
{
    private GameObject block;
    private bool mouseIsDragging = false;
    public int rotDegrees = 0;
    public int rotDegreesIncr = 0;
    private bool RmouseDown;

    // Start is called before the first frame update
    void Start()
    {
        block = this.gameObject;
    }

    private void OnMouseDown()
    {
        mouseIsDragging = true;
        block.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnMouseUp()
    {
        mouseIsDragging = false;
        block.GetComponent<BoxCollider2D>().enabled = true;
    }

    //click destro, ruoto object di rotDegrees gradi
    private void BlocksRotation()
    {
        block.transform.rotation = Quaternion.Euler(0, 0, rotDegrees);
        rotDegrees += rotDegreesIncr;
        Debug.Log("giraaaaaaaaaaa");
    }


    private void Update()
    {
        if (mouseIsDragging == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            if (Input.GetMouseButtonDown(1) == true)
            {
                BlocksRotation();
            }
        }
        else { };
    }

}
