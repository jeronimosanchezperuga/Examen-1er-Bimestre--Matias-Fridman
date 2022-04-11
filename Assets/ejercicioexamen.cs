using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioexamen : MonoBehaviour {
    public string moneda;
    public int montoaconvertir;
    int devolucion;
    int R = 23;
    int D = 200;
    int E = 122;
	// Use this for initialization
	void Start () {
        if (montoaconvertir < 1000)
        {
            Debug.Log("Tiene que cambiar mas de $1000");
        }
            
        
          if (moneda != "D"&&moneda!="R"&&moneda!="E")
            {
                Debug.Log("La moneda que ingreso no es valida");
            }
        
        if (moneda == "D"&&montoaconvertir>1000)
        {
            devolucion = montoaconvertir / D;
            Debug.Log(montoaconvertir + " pesos argentinos equivalen a " + devolucion + " " + moneda);
        }
        if (moneda == "R"&& montoaconvertir>1000)
        {
            devolucion = montoaconvertir / R;
            Debug.Log(montoaconvertir + " pesos argentinos equivalen a " + devolucion + " " + moneda);
        }
        if (moneda == "E"&&montoaconvertir>1000)
        {
            devolucion = montoaconvertir / E;
            Debug.Log(montoaconvertir+" pesos equivalen a "+devolucion+" "+moneda);
        }
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
