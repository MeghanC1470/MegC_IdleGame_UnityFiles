using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCarbon : MonoBehaviour
{
    public static int CarbonCount;
    public GameObject CarbonDisplay;
    public int InternalCarbon;
    void Update()
    {
        InternalCarbon = CarbonCount;
        CarbonDisplay.GetComponent<Text>().text = "Carbon Points: " + InternalCarbon;
    }
}
