using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaProiettili : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Proiettile> listaProiettili = new List<Proiettile>();

        listaProiettili.Add(new Freccia(10));
        listaProiettili.Add(new PallaMagica(5));

        //Posso usare un FOR
        //for (int i = 0; i < listaProiettili.Count; i++)
        //{
        //    listaProiettili[i].Lancia();
        //}

        //O anche un FOREACH
        foreach (Proiettile bullet in listaProiettili)
        {
            bullet.Lancia();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
