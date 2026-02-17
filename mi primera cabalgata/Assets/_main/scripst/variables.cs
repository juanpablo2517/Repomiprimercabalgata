
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
    public bool isBoll;
    [SerializeField] private TMP_InputField _inputFIeld;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxcollider;
    void Start()

    {
        _cubo.material.color = Color.blue;
       Debug.Log(_saludo.text = "hola" + myName);
        _boxcollider.isTrigger = true;
    

        
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputFIeld.text;
        _saludo.text = "hola" + myName;
    }
}
