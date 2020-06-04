using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resultados : MonoBehaviour
{
    private static int Aciertos { set; get; }
    private static int Fallos { set; get; }

    public TextMeshProUGUI txt_aciertos;
    public TextMeshProUGUI txt_fallos;

    // Start is called before the first frame update
    void Start()
    {
        txt_aciertos.text = Aciertos.ToString();
        txt_fallos.text = Fallos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void sumarAcierto()
    {
        Aciertos++;
    }

    public static void sumarFallo()
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

    public void CammbiarEscena()
    {
        SceneManager.LoadScene("Inicio");
    }

}
