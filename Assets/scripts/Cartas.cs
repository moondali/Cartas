using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartas : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, gente!");
        Debug.Log("Sempre que pressionar a tecla espaço, uma carta será sorteada!");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           int numbers = Random.Range(1, 13);
           int naipe = Random.Range(1, 4);
           string naipeText = string.Empty;
           string numbersText;
           
         

           if( naipe == 1)
           {
               naipeText = "paus";
           }
              else if (naipe == 2)
             {
                naipeText = "ouros"; 
             }                      
           
             else if (naipe == 3)
             { 
                 naipeText = "copas";
             }                    
           
             else if (naipe == 4)
             {
                naipeText = "espadas";
             }

                else 
                {
                   naipeText =  naipeText.ToString();
                }
            
            
           if ( numbers == 11)
           {
              numbersText = "valete";
           }
             else if ( numbers == 12)
             {
               numbersText = "dama";
             }
             else if ( numbers == 13)
             {
               numbersText = "rei";
             }
             else if ( numbers == 1)
             {
               numbersText = "às";
             }

             if(numbers == 1);
               { 
                 numbersText = numbers.ToString(); 
               }
            

           Debug.Log("A carta que saiu foi " + numbersText + " de " + naipeText);
           restart();
           
        }
    
    }
    void restart()
    {
        Debug.Log("Caso queiras outro resultado, prime espaço de novo");
    }
}
