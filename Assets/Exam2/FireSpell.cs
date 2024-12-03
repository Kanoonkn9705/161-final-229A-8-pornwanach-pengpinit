using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void UseSpell()
    {
        Debug.Log("FireStorm spell Burn them all !!!");
    }

    public override void EnemyName()
    {
        Debug.Log("Spell on target : Ice Bear");       
    }

    public override void TakeDamageEnemy()
    {
        Debug.Log("Spell on Ice Bear with power : 10");
    }
    void Start()
    {
        UseSpell();
        EnemyName();
        TakeDamageEnemy();
    }

}
