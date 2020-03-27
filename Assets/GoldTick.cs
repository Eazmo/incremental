using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldTick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Ticker", 0.0f, 1.0f);
    }

    void Ticker()
    {
        Click.Gold = Click.Gold + (GuardTower.NumberOfTowers * 1 * GTUpgrade.Multiplier) + (Archer.NumberOfArchers * 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
