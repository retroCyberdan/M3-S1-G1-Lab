using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public override void Lancia()
    {
        Debug.Log($"La palla magica è stata lanciata ad una velocità di {velocita}");
    }

    public PallaMagica(float velocita) : base(velocita)
    {

    }
}
