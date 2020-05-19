using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasajero : MonoBehaviour
{
    public Dictionary<int, ModelPasajero> Pasajeros { get; set; }

    public Pasajero()
    {
        Pasajeros = new Dictionary<int, ModelPasajero>();

        ModelPasajero informacion;

        informacion = new ModelPasajero("A", "G", "UAIS", 9, "Comer carne cruda", "Ninguno", 36, false);
        Pasajeros.Add(0, informacion);

        informacion = new ModelPasajero("B", "H", "VAIS", 5, "Puede volar", "Ninguno", 36, true);
        Pasajeros.Add(1, informacion);

        informacion = new ModelPasajero("C", "I", "CAIS", 5, "Puede volar", "Ninguno", 36, true);
        Pasajeros.Add(2, informacion);

        informacion = new ModelPasajero("D", "K", "CAIS", 5, "Puede volar", "Ninguno", 36, true);
        Pasajeros.Add(3, informacion);
    }

}
