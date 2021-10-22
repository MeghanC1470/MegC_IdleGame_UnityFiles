using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCalcium : MonoBehaviour
{
    public static int CalciumCount;
    public GameObject CalciumDisplay;
    public int InternalCalcium;
    void Update()
    {
        InternalCalcium = CalciumCount;
        CalciumDisplay.GetComponent<Text>().text = "Calcium Points: " + InternalCalcium;
    }
}
