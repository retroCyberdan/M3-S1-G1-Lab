using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string nome { get; set; }
    public int vita { get; set; }
    public int danno { get; set; }

    public abstract void Attack();
    public abstract void TakeDamage(int damage);
    public Character(string nome, int vita, int danno)
    {
        this.nome = nome;
        this.vita = vita;
        this.danno = danno;
    }
}
