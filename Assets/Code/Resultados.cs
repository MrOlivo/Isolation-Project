using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resultados : MonoBehaviour
{
    private static int Aciertos { set; get; }
    private static int Fallos { set; get; }
    
    private static int AciertosGlobales { set; get; }
    private static int FallosGlobales { set; get; }

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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Inicio");
        }
    }

    public static void sumarAcierto()
    {
        Aciertos++;
        AciertosGlobales++;
    }

    public static void sumarFallo()
    {
        Fallos++;
        FallosGlobales++;
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
        Aciertos = 0;
        Fallos = 0;
        SceneManager.LoadScene("Inicio");
    }

}
