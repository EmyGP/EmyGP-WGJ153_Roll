using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakiRollSpawner : MonoBehaviour
{
    public GameObject makiRoll1;
    public int widthOffset;
    public int heightOffset;
    public int width;
    public int height;

    void Start()
    {
        for (int y=0; y<height; ++y)
        {
            for(int x=0; x<width; ++x)
            {
                Instantiate(makiRoll1, new Vector3(x+widthOffset, y+heightOffset, 0), Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
