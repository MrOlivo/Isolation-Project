using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public static int Passenger { get; set; }

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

        Pasajero p = gameObject.AddComponent<Pasajero>();
        listaPasajeros = p.Pasajeros;

        string nombre = txtElement.name;

        switch (nombre)
        {
            case "estancia":
                txtElement.text = "Duración de la estadia\n" + listaPasajeros[Passenger].Estancia;
                break;
            case "habitos":
                txtElement.text = "Habitos\n" + listaPasajeros[Passenger].Habitos;
                break;
            case "sintomas":
                txtElement.text = "Sintomas\n" + listaPasajeros[Passenger].Sintomas;
                break;
            case "temperatura":
                txtElement.text = "Temperatura\n" + listaPasajeros[Passenger].Temperatura.ToString();
                break;
            default:
                break;
        }
    }
}
