using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string moneda;
    public int monto;

    void Start()
    {
        string monedaelegida = "";
        int montoconver = 0;
        if(monto < 1000)
        {
            Debug.Log("El monto minimmo es $1000");
        }

        else
        {
            if (moneda == "d" || moneda == "D")
            {
                montoconver = monto * 112;
                monedaelegida = "Dolares";
            }

            if(moneda == "e" || moneda == "E")
            {
                montoconver = monto * 122;
                monedaelegida = "Euros";
            }
            
            if (moneda == "r" || moneda == "R")
            {
                montoconver = monto * 23;
                monedaelegida = "Reales";
            }
            
            else{
                Debug.Log("Ingresa una letra valida: D para convertir a Dolares, R para convertir Reales y E para convertir a Euros");
            }
        }

        Debug.Log(monto + " pesos argentinos equivalen a " + montoconver + " " + monedaelegida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
