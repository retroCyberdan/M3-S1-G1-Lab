using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Archer : Character
{
    public override void Attack()
    {
        int numeroFreccie = 2;
        
        for (int i = 1; i <= numeroFreccie; i++)
        {
            Debug.Log($"{nome} lancia la {i}° freccia e infligge {danno} danni");
        }
        
    }

    public override void TakeDamage(int danno)
    {
        vita -= danno;
        Debug.Log($"{nome} subisce {danno} danni e rimane con {vita} punti vita");
    }

    public Archer(string nome, int vita, int danno) : base(nome, vita, danno)
    {

    }
}
