using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Resultados : MonoBehaviour
{
    private static int Aciertos { set; get; }
    private static int Fallos { set; get; }

    public TextMeshProUGUI aci;
    public TextMeshProUGUI err;

    // Start is called before the first frame update
    void Start()
    {
        aci.text = Aciertos.ToString();
        err.text = Fallos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void sumarAcierto()
    {
        Aciertos++;
    }

    public static void sumarFallos()
    {
        Fallos++;
    }

    public static int obtenerAciertos()
    {
        return Aciertos;
    }

    public static int obtenerFallos()
    {
        return Fallos;
    }

}
