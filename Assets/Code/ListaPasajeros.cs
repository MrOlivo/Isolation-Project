﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasajero : MonoBehaviour
{
    public Dictionary<int, ModelPasajero> Pasajeros { get; set; }

    public Pasajero()
    {
        Pasajeros = new Dictionary<int, ModelPasajero>();
        System.Random rn = new System.Random();

        string file = "MOCK_DATA";
        string path = "Assets/Code/"+ file +".csv";

        var objs = Sinbad.CsvUtil.LoadObjects<ModelPasajero>(path);

        for(int i = 0; i < objs.Count; i++){

            objs[i].Covid = (objs[i].Temperatura > 38 && rn.Next(0, 9) > 7) ? true : false;

            Pasajeros.Add(i, objs[i]);

        }
    }

}
