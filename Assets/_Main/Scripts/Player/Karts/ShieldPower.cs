﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPower : IPower
{
    private GameObject cloneShieldPrefab;
    
    [SerializeField] private GameObject shieldPrefab;
    [SerializeField] private float shieldDuration = 2f;
    
    public override void Execute()
    {
        //Spawns shield at the specified location
        cloneShieldPrefab = Instantiate(shieldPrefab,parent.transform.position,Quaternion.identity,parent.transform);
        //Destroys shield after the duration
        Object.Destroy(cloneShieldPrefab, shieldDuration);
        //Turns off the object
        this.enabled = false;
    }

    private void Update()
    {
        //If not enabled stops
        if (!this.enabled) return;
        Execute();
    }
}