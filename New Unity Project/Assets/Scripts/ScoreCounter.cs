using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private GameObject[] makiRolls;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ScoreCount()
    {
        makiRolls = GameObject.FindGameObjectsWithTag("Makiroll");
        int makiRollsN = GameObject.FindGameObjectsWithTag("Makiroll").Length;
            //not so sure about the following one- The goal was printing the numer of makirolls on the text object
        scoreText.text = makiRollsN.ToString();
    }
}
