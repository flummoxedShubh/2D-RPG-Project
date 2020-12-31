using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//abstract identifier to indicate that this class can't be instantiated & must be inherited
public abstract class Character : MonoBehaviour
{
    public int hitPoints;
    public int maxHitPoints;
}
