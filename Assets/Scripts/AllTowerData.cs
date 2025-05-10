using System.Collections;
using System.Collections.Generic;
using TowerDefense.Towers;
using UnityEngine;

public class AllTowerData : MonoBehaviour
{
    private Tower[] allTowers;

    public Tutorial tutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InfectTower()
    {
        allTowers = FindObjectsOfType<Tower>();

        int randomIndex = Random.Range(0, allTowers.Length);
        Tower randomTower = allTowers[randomIndex];

        randomTower.isDisabled = true; // Maybe Change later

        randomTower.currentTowerLevel.SetAffectorState(false);
        randomTower.GetComponent<ParticleTower>().myParticles.Play();

        tutorial.infected = true;
    }
}
