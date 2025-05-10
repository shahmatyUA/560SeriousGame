using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense.Towers;

public class ParticleRocket : MonoBehaviour
{

    public ParticleSystem myParticles;

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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            tower.currentTowerLevel.SetAffectorState(false);
            myParticles.Play();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            tower.currentTowerLevel.SetAffectorState(true);
            myParticles.Stop();
        }
    }
}
