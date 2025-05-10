using System.Collections;
using System.Collections.Generic;
using TowerDefense.Towers;
using UnityEngine;

public class ParticleTower : MonoBehaviour
{

    public ParticleSystem myParticles;

    // public bool towerDisabled = false;

    private Tower tower;
    // Start is called before the first frame update
    void Start()
    {
        tower = GetComponent<Tower>();
        myParticles.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool towerDisabled = tower.isDisabled;
        //Debug.Log("towerDisabled: " + towerDisabled);
        if (towerDisabled)
        {
            //Debug.Log("particles playing");
            //myParticles.Play();
            //tower.currentTowerLevel.SetAffectorState(false);
            
        }
        else 
        {
            //tower.currentTowerLevel.SetAffectorState(true);
            //myParticles.Stop();
        }
    }
}
