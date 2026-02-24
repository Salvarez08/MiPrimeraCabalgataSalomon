using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Estoy siendo tocado");
    }
    void OnCollisionExit2D(Collision2D collision)

    {
        Debug.Log("OnCollisionExit");
    }

     void OnCollisionStay2D(Collision2D collision)

    {
        Debug.Log("OnCollisionStay");
    }

}
