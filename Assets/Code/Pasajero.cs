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
        GetListaPasajeros().Add(1, informacion);
        GetListaPasajeros().Add(2, informacion);
    }

}
