using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCarbonScript : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton()
    {

        if (GlobalCarbon.CarbonCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Oops! Not enough Carbon to use!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCarbon.CarbonCount -= 1;
            GlobalCalcium.CalciumCount += 1;
        }
    }
}
