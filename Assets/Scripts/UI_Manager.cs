using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject panelTask;

    public void OpenPanelTask()
    {
        panelTask.SetActive(true);
    }

    public void ClousePanelTask()
    {
        panelTask.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
