using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardTower : MonoBehaviour
{
    public static int NumberOfTowers = 0;
    public Text CurrentNumberGT = null;
    public static float CostOfTower = 5;
    public static float baseCost = 5;
    public Text towerCost = null;
    public Button GuardTowerButton;
    private float NumberOfTowersF;
    


    // Start is called before the first frame update
    void Start()
    {
        GuardTowerButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (Click.Gold >= CostOfTower)
        {
            NumberOfTowers = NumberOfTowers + 1;
            Click.Gold = Click.Gold - CostOfTower;
            NumberOfTowersF = NumberOfTowers;
            CostOfTower = baseCost * Mathf.Pow(1.07f, NumberOfTowersF);
        }
    }



    // Update is called once per frame
    void Update()
    {
        CurrentNumberGT.text = NumberOfTowers.ToString();
        towerCost.text = CostOfTower.ToString();
        
    }
    
}
