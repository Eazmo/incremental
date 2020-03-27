using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Button ClickButton;
    public static float Gold = 500000;
    private int addGold = 1;

    // Start is called before the first frame update
    void Start()
    {
        ClickButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Gold = addGold + Gold;
        Debug.Log("Clicked");
    }

    // Update is called once per frame
    void Update()
    {
    }
}

