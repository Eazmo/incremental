using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currentGold : MonoBehaviour
{
    public static int Gold = 1;
    public Text currentGoldText = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentGoldText.text = Click.Gold.ToString();
    }
}
