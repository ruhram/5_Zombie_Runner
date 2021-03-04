using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammo = 20;

    public int GetCurrentAmmo()
    {
        return ammo;
    }

    public void ReduceCurrentAmmo()
    {
        ammo--;
    }
}
