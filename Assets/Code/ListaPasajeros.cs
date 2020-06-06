using System.Collections;
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

        List<ModelPasajero> objs = Sinbad.CsvUtil.LoadObjects<ModelPasajero>(path);

        for(int i = 0; i < objs.Count; i++){

            bool original = objs[i].Covid;

            if (objs[i].Temperatura >= 39.0 && rn.NextDouble() < 0.8)
            {
                objs[i].Covid = true;
            }
            else if (objs[i].Temperatura >= 37.0 && rn.NextDouble() < .2)
            {
                objs[i].Covid = true;
            }

            objs[i].Estancia = CambiarEstancia(objs[i].Estancia);

            Pasajeros.Add(i, objs[i]);

        }
    }

    int CambiarEstancia(int org)
    {
        if (org >= 58)
        {
            org /= 4;
        }
        else if (org >= 36)
        {
            org /= 3;
        }
        else if (org >= 20)
        {
            org /= 2;
        }

        return org;
    }

}
