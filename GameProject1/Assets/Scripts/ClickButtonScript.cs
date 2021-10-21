using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonScript : MonoBehaviour
{
    public GameObject textbox;

    public void ClickTheButton ()
    {
        textbox.SetActive(true);
    }


}
