using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public override void Attack()
    {
        Debug.Log($"{nome} casta un incantesimo e infligge {danno} danni");
    }

    public override void TakeDamage(int danno)
    {
        vita -= danno;
        Debug.Log($"{nome} subisce {danno} danni e rimane con {vita} punti vita");
    }

    public Mage(string nome, int vita, int danno) : base(nome, vita, danno)
    {

    }
}
