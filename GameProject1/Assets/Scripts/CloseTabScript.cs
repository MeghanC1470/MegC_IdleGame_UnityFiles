using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTabScript : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        textBox.SetActive(false);
    }
}
