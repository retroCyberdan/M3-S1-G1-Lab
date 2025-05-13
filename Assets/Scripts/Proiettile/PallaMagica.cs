using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public override void Lancia()
    {
        Debug.Log($"La palla magica � stata lanciata ad una velocit� di {velocita}");
    }

    public PallaMagica(float velocita) : base(velocita)
    {

    }
}
