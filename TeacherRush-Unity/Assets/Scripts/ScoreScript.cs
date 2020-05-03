using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int lifes { get; set; }
    public int startLifes = 50;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        lifes = startLifes;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + lifes;
    }

 /*   public int UpdateLifes(int amount)
    {
        return lifes + amount;
    }*/
}
