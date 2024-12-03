using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void UseSpell()
    {
        Debug.Log("Ice Beam spell Freeze them !!!");
    }

    public override void EnemyName()
    {
        Debug.Log("Spell on target : Fire Dragon");
    }

    public override void TakeDamageEnemy()
    {
        Debug.Log("Spell on Fire Dragon with power : 15");
    }
    void Start()
    {
        UseSpell();
        EnemyName();
        TakeDamageEnemy();
    }
}
