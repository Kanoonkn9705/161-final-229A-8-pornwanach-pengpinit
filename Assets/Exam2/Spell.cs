using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public virtual void UseSpell()
    {

    }

    public abstract void EnemyName();

    public abstract void TakeDamageEnemy();
}
