using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
    public override void Lancia()
    {
        Debug.Log($"La freccia è stata lanciata ad una velocità di {velocita}");
    }

    public Freccia(float velocita) : base(velocita)
    {

    }
}
