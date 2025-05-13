using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> listaPersonaggi = new List<Character>();

        listaPersonaggi.Add(new Warrior("Zack",100, 10));
        listaPersonaggi.Add(new Mage("Aerith", 40, 12));
        listaPersonaggi.Add(new Archer("Vincent", 80, 7));

        foreach (Character character in listaPersonaggi)
        {
            Debug.Log($"{character.nome} ha {character.vita} punti vita");
            character.Attack();
            character.TakeDamage(Random.Range(1, 21));
            Debug.Log($"A {character.nome} restano {character.vita} punti vita");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
