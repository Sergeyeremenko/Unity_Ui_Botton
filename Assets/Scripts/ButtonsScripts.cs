using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonsScripts : MonoBehaviour
{
    private BoxCollider2D myBox2d;
    private Color myColor1 = Color.white;

    void Start()
    {
        myBox2d = GetComponent<BoxCollider2D>();
        GetComponent<Image>().color = Color.white;
    }

    public void Button()
    {
        myBox2d.enabled = !myBox2d.enabled;
        GetComponent<Image>().color = Color.red;
    }
}
