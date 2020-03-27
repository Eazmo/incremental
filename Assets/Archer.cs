using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Archer : MonoBehaviour
{
    public static int NumberOfArchers = 0;
    public Text CurrentNumberArchers = null;
    private float CostOfArchers = 60;
    private float baseCost = 60;
    public Text archerCost = null;
    public Button ArcherButton;
    private float NumberOfArchersF;



    // Start is called before the first frame update
    void Start()
    {
        ArcherButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (Click.Gold >= CostOfArchers)
        {
            NumberOfArchers++;
            Click.Gold = Click.Gold - CostOfArchers;
            NumberOfArchersF = NumberOfArchers;
            CostOfArchers = baseCost * Mathf.Pow(1.15f, NumberOfArchersF);
        }
    }



    // Update is called once per frame
    void Update()
    {
        CurrentNumberArchers.text = NumberOfArchers.ToString();
        archerCost.text = CostOfArchers.ToString();

    }

}
