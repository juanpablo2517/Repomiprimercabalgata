using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coliciones : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
    }




    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2");   
    }

}    

