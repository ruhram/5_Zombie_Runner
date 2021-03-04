using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float HitPoint = 100f;
    // Start is called before the first frame update
    public void TakeDamage(float damage)
    {
        HitPoint -= damage;
        if (HitPoint <= 0)
        {
            print("You Dead");
        }
    }
}
