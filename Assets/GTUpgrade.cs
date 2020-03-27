using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GTUpgrade : MonoBehaviour
{
    public Button UpgradeGT;
    public static int Multiplier = 1;



    // Start is called before the first frame update
    void Start()
    {
        UpgradeGT.onClick.AddListener(UpgradeFunction);
    }

    void UpgradeFunction()
    {
        if (GuardTower.NumberOfTowers >= 100)
        {
            GuardTower.NumberOfTowers = GuardTower.NumberOfTowers - 100;
            GuardTower.baseCost = GuardTower.CostOfTower;
            Multiplier = Multiplier * 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
