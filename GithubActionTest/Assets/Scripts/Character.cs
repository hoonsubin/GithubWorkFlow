using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public uint HP = 10;

    public void OnDamage(uint damage)
    {
        HP -= damage;
    }
}
