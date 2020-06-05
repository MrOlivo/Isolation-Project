using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Dias : MonoBehaviour
{
    public TMPro.TextMeshProUGUI txtElement;

    private static int dias = 1;
    private float timeLeft = 5;

    // Start is called before the first frame update
    void Start()
    {
        txtElement.text = "Dia " + dias;
        dias++;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0)
        {
            CammbiarEscena();
        }
    }

    public void CammbiarEscena()
    {
        SceneManager.LoadScene("Principal");
    }
}
