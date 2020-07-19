using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasajero : MonoBehaviour
{

    string ruta;

    string DBFileName = "MOCK_DATA.csv";

    public Dictionary<int, ModelPasajero> Pasajeros { get; set; }

    public void Pasajerocsv(string rt )
    {
        Pasajeros = new Dictionary<int, ModelPasajero>();
        System.Random rn = new System.Random();

        // ruta = Application.dataPath + "/StreamingAssets/" + DBFileName;

        //string path = "Assets/Code/MOCK_DATA.csv";

       List<ModelPasajero> objs = Sinbad.CsvUtil.LoadObjects<ModelPasajero>(rt);


        for (int i = 0; i < objs.Count; i++){

            if (objs[i].Temperatura >= 39.0 && rn.NextDouble() < 0.8)
            {
                objs[i].Covid = true;
            }

            objs[i].Estancia = CambiarEstancia(objs[i].Estancia);

            Pasajeros.Add(i, objs[i]);

        }
    }

    public void Pasajerosqlite()
    {
        Pasajeros = new Dictionary<int, ModelPasajero>();

        System.Random rn = new System.Random();

        List<ModelPasajero> objs = ControladorSQLite.objs;
    
        for (int i = 0; i < objs.Count; i++)
        {
            print(objs[i].Destino);

            if (objs[i].Temperatura >= 39.0 && rn.NextDouble() < 0.8)
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
