using System.Collections;
using System.Collections.Generic;
using TowerDefense.Towers;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject buildText;
    public GameObject infectText;

    public bool firstTower = false;

    public bool done = false;

    public bool infected = false;

    Tower[] allTowers;
    // Start is called before the first frame update
    void Start()
    {
        buildText.SetActive(true);
        infectText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (done)
        {
            buildText.SetActive(false);
            infectText.SetActive(false);
            return;
        }
        allTowers = FindObjectsOfType<Tower>();

        Debug.Log("All Towers: " + allTowers.Length);
        if (allTowers.Length >= 1)
        {
            firstTower = true;
        }

        Debug.Log("First Tower: " + firstTower);
        if (firstTower)
        {
            buildText.SetActive(false);

            if (infected)
            {
                infectText.SetActive(true);
            }

        }

        


    }
}
