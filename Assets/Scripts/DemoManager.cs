using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (canvas1.activeSelf)
            {
                canvas1.SetActive(false);
                mainCanvas.SetActive(true);
            }
            else 
            {
                mainCanvas.SetActive(false);
                canvas1.SetActive(true);
                
            }

        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (canvas2.activeSelf)
            {
                canvas2.SetActive(false);
                mainCanvas.SetActive(true);
            }
            else
            {
                mainCanvas.SetActive(false);
                canvas2.SetActive(true);
                
            }

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (canvas3.activeSelf)
            {
                canvas3.SetActive(false);
                mainCanvas.SetActive(true);
            }
            else
            {
                mainCanvas.SetActive(false);
                canvas3.SetActive(true);
                
            }

        }
    }
}
