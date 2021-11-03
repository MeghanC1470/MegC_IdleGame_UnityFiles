using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClickerScript : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalCarbon.CarbonCount += 1;
    }
}
