﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPower : IPower
{
    private GameObject cloneShieldPrefab;
    public AudioSource drownedAudio;
    
    [SerializeField] private GameObject shieldPrefab;
    [SerializeField] private float shieldDuration = 2f;
    
    public override void Execute()
    {
        drownedAudio.Play();
        //Spawns shield at the specified location
        cloneShieldPrefab = Instantiate(shieldPrefab,parent.transform.position,Quaternion.Euler(-90,0,0 ),parent.transform);
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