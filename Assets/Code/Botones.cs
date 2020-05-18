using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public static int passenger;

    //private bool banderaStay = true;
    //private bool banderaSymptoms = true;
    //private bool banderaHabits = true;
    //private bool banderaTemp = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarTexto(Text txtElement)
    {
        Dictionary<int, ModelPasajero> listaPasajeros;

        Pasajero pasajero = gameObject.AddComponent<Pasajero>();
        listaPasajeros = pasajero.ListaPasajeros;

        string nombre = txtElement.name;

        switch (nombre)
        {
            case "estancia":
                txtElement.text += listaPasajeros[0].Estancia;
                break;
            case "habitos":
                txtElement.text += listaPasajeros[0].Habitos;
                break;
            case "sintomas":
                txtElement.text += listaPasajeros[0].Sintomas;
                break;
            case "temperatura":
                txtElement.text += listaPasajeros[0].Temperatura;
                break;
            default:
                break;
        }
    }
}
