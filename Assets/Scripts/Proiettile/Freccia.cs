using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
    public override void Lancia()
    {
        Debug.Log($"La freccia � stata lanciata ad una velocit� di {velocita}");
    }

    public Freccia(float velocita) : base(velocita)
    {

    }
}
