using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpell : Spell
{
    public override void UseSpell()
    {
        Debug.Log("Air Slash spell Cut them all !!!");
    }

    public override void EnemyName()
    {
        Debug.Log("Spell on target : Demon Tree");
    }

    public override void TakeDamageEnemy()
    {
        Debug.Log("Spell on Demon Tree with power : 5");
    }
    void Start()
    {
        UseSpell();
        EnemyName();
        TakeDamageEnemy();
    }
}
