using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1CanvasManager : MonoBehaviour
{
    public GameObject[] questions;

    public GameObject OverAllCanvas;
    public GameObject mainCanvas;

    public int index = 0;
    

    public void ShowCanvas()
    {
        for (int i = 0; i < questions.Length; i++)
        {
            if (i == index)
            {
                questions[i].SetActive(true);
            }
            else
            {
                questions[i].SetActive(false);
            }
        }
        index++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OverAllCanvas.activeSelf)
            {
                mainCanvas.SetActive(true);
                OverAllCanvas.SetActive(false);
            }
            else
            {
                mainCanvas.SetActive(false);
                OverAllCanvas.SetActive(true);
                ShowCanvas();
            }
            
        }
    }
}
