using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    //int numeros enteros
    //float 1.2f, 3.5f
    //bool verdadero falso
    //string texto "cadena de texto o caracteres"
    // Start is called before the first frame update

    //variables unity gameEngine
    string myName="juan";
    void Start()
        
    {
        Debug.Log("hola" + myName);

       Debug.Log("hola,mundo start()!!");
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola,mundo start()!!");
    }
}
