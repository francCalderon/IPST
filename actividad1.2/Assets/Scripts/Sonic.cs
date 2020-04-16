using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonic : MonoBehaviour
{
    public int fuerza;
    public float salto;
    public float Speed;
    public float vertical;
    public float horizontal;
    // Se va a iniciar al momento de iniciar el videoJuego
    void Start()
    {
        //posión del objeto: vector2 ejes x e y, en frames
        this.transform.position = new Vector2(-6f,0);
    }

    // Se va a ejecutar frame por frame, a medida que vas jugando
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");//para el teclado por defoult horizontal del teclado
        vertical = Input.GetAxis("Vertical");//para el teclado por defoult vertical del teclado

        //posicion se va a transladar en el vector2D * velocidad * velocidad normalizada
        transform.Translate(new Vector2(horizontal, vertical) * Speed * Time.deltaTime);

    //metodo ambiguo de desplazamiento
        /*if(Input.GetKey("a")){
            //obtengo el Rigidbody y uso la fuerza con AddForce en el eje x e y
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-15f,0));
        }
        if(Input.GetKey("d")){
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(15f,0));
        }
        if(Input.GetKey("w")){
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,salto));
        }*/
    }
    //Primera opcion de desplazamiento por fuerza
    void Caminar(){

    }

}
