using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    public static int passenger;

    private static bool banderaStay = true;
    private static bool banderaSymptoms = true;
    private static bool banderaHabits = true;
    private static bool banderaTemp = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Botones()
    {
        
    }

    public void CambiarTexto(Text txtElement)
    {
        Dictionary<int, string[]> listaPasajeros;
        Pasajero pasajero = gameObject.AddComponent<Pasajero>();
        listaPasajeros = pasajero.GetListaPasajeros();

        string nombre = txtElement.name;

        if (nombre.Equals("stay") && banderaStay)
        {
            txtElement.text += listaPasajeros[passenger][3] + " dias";
            banderaStay = false;
        }
        else if (nombre.Equals("habits") && banderaHabits)
        {
            txtElement.text += listaPasajeros[passenger][4];
            banderaHabits = false;
        }
        else if (nombre.Equals("symptoms") && banderaSymptoms)
        {
            txtElement.text += listaPasajeros[passenger][5];
            banderaSymptoms = false;
        }
        else if (nombre.Equals("temperature") && banderaTemp)
        {
            txtElement.text += listaPasajeros[passenger][6] + " º Celsius";
            banderaTemp = false;
        }
    }
}
