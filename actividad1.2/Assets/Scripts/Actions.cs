using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public float fuerzaSalto;
    //metodo que recibe el parametro de colicion
    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "plataforma"){
            Debug.Log("chocando en el trampolin");
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,fuerzaSalto));
        }
    }
}
