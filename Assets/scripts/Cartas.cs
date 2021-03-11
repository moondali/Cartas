using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartas : MonoBehaviour
{
    string[] CartasNomes = {"Ás" , "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , "10" , "Valete" , "Dama" , "Rei"};
    string[] CartasSimbolo = {"Ouro", "Copas", "Paus", "Espadas"};
    string CartasNomesSimbolo1;
    string CartasNomesSimbolo2;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, Mundo!");
    }

    private void Inicio()
    {
        Debug.Log("Sempre que pressionar a tecla espaço, uma carta será sorteada!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            string CartasNomesSimbolo1 = CartasNomes[Random.Range(0, CartasNomes.Length)];
            string CartasNomesSimbolo2 = CartasSimbolo[Random.Range(0,CartasSimbolo.Length)];

            Debug.Log("A carta que saiu foi " + CartasNomes + "de" + CartasSimbolo); 
            
            Inicio();

        }
    
    }

    
    

}
