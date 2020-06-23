using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private GameObject[] makiRolls;
    public Text scoreText;
    public Text NmakiText;
    public Image finalImg;

    void Start()
    {
        NmakiText.enabled = false;
        scoreText.enabled = false;
        finalImg.enabled = false;
    }

    //problemone qui: Score count trova tutti gli obj con il tag makirolls. Ovvero quelli che non sono stati ancora distrutti
    //e che quindi dovrebbero essere quelli dentro ai vari box. Il problema è che per come è strutturato lo spawner ci sarà sempre
    //l'ultimo obj taggato makiroll che sarà contato, perchè quando parte la coroutine che accede a ScoreCounter (questo script) un maki
    //sta ancora vagando per la schermata, e sarà quindi contato come makirollsN, anche se in seguito verrà distrutto.
    //TEMP solution: nella coroutine dello spawner, imposto waitforsec che dia il tempo anche all'ultimo maki di "sistemarsi"
    public void ScoreCount()
    {
        makiRolls = GameObject.FindGameObjectsWithTag("Makiroll");
        int makiRollsN = GameObject.FindGameObjectsWithTag("Makiroll").Length;
        finalImg.enabled = true;
        NmakiText.enabled = true;
        scoreText.enabled = true;
        scoreText.text = makiRollsN.ToString();
    }

    //void Update()
    //{
    //    //ScoreCount();
    //}
}
