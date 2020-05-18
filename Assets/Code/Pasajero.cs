using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasajero : MonoBehaviour
{
    private Dictionary<int, string[]> listaPasajeros;

    public Dictionary<int, string[]> GetListaPasajeros()
    {
        return listaPasajeros;
    }

    public void SetListaPasajeros(Dictionary<int, string[]> value)
    {
        listaPasajeros = value;
    }

    private string[] informacion;

    public Pasajero()
    {
        SetListaPasajeros(new Dictionary<int, string[]>());
        informacion = new string[] {"Nombre", "Nacionalidad", "Viaja a",
            "Estancia", "Habitos", "Sintomas", "Temperatura", "Positivo" };
        GetListaPasajeros().Add(0, informacion);

        informacion = new string[] {"Nombre", "Nacionalidad", "Viaja a",
            "Estancia", "Habitos", "Sintomas", "Temperatura", "Positivo" };
        GetListaPasajeros().Add(1, informacion);

        informacion = new string[] {"Ana", "Guatemalteca", "Ucrania",
            "9", "Comer carne cruda", "Ninguno", "36", "Negativo" };
        GetListaPasajeros().Add(2, informacion);

        informacion = new string[] {"Mario Rivera", "Mexicano", "Corea del Sur",
            "5", "Puede volar", "Ninguno", "36", "Positivo" };
        GetListaPasajeros().Add(3, informacion);
    }

}
