using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
public class Ej_2 : MonoBehaviour
{
    public float producto_1;
    public float producto_2;
    public float producto_3;
    public float dinero; 
    // Start is called before the first frame update
    void Start()
       
    {
        float res;
        float res_1;
        if (producto_1 + producto_2 + producto_3 < dinero)
        {
            Debug.Log(" Si le alcanza el dinero para comprar");
            res = dinero - producto_1 + producto_2 + producto_3;
            Debug.Log(" Le falta" + res);
        }
        else if (producto_1 + producto_2 + producto_3 > dinero)
        {
            Debug.Log(" No le alcanza el dinero para comprar");
            res_1 = producto_1 + producto_2 + producto_3 - dinero;
            Debug.Log(" Le falta" + res_1);
        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
