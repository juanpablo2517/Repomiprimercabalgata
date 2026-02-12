
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class variables : MonoBehaviour
{
    //int numeros enteros
    //float 1.2f, 3.5f
    //bool verdadero falso
    //string texto "cadena de texto o caracteres"
    // Start is called before the first frame update

    //variables unity gameEngine
  public  string myName = "juan";
  public  int edad = 23;

   [SerializeField] private Tmp_ImputField _imputFIeld;
    [SerializeField] private TMP_Text _saludo;

    void Start()

    {
       
        _saludo.text = "hola" + myName;

        myName = _imputFIeld 

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola,mundo start()!!");
    }
}
