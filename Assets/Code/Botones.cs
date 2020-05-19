﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public static int passenger { get; set; }

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

        Pasajero p = gameObject.AddComponent<Pasajero>();
        listaPasajeros = p.Pasajeros;

        string nombre = txtElement.name;

        switch (nombre)
        {
            case "estancia":
                txtElement.text = "Duración de la estadia\n" + listaPasajeros[passenger].Estancia;
                break;
            case "habitos":
                txtElement.text = "Habitos\n" + listaPasajeros[passenger].Habitos;
                break;
            case "sintomas":
                txtElement.text = "Sintomas\n" + listaPasajeros[passenger].Sintomas;
                break;
            case "temperatura":
                txtElement.text = "Temperatura\n" + listaPasajeros[passenger].Temperatura;
                break;
            default:
                break;
        }
    }
}
