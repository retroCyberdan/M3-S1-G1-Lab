using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public override void Attack()
    {
        Debug.Log($"{nome} attacca e infligge {danno} danni");
    }

    public override void TakeDamage(int danno)
    {
        vita -= danno;
        Debug.Log($"{nome} subisce {danno} danni e rimane con {vita} punti vita");
    }

    public Warrior(string nome, int vita, int danno) : base(nome, vita, danno)
    {

    }
}
