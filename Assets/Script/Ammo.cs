﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] ammoSlot[] ammoSlots;

    [System.Serializable]
    private class ammoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }
    public int GetCurrentAmmo()
    {
        return ammo;
    }

    public void ReduceCurrentAmmo()
    {
        ammo--;
    }
}
