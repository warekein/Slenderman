using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject slender;
    [SerializeField] GameObject personaje;
    [SerializeField] Transform[] arrayPuntosSalida;
    [SerializeField] GameObject panelFinal;
    [SerializeField] private TextMeshProUGUI textoFinal;

    private int puntoSalida;

    private void Start()
    {
        EstablecerPunto(personaje);
        CrearNuevoSlender();
    }

    private void EstablecerPunto(GameObject objeto)
    {
        puntoSalida = Random.Range(0, arrayPuntosSalida.Length);
        objeto.transform.position = arrayPuntosSalida[puntoSalida].position;
    }

    public void CrearNuevoSlender()
    {
        Instantiate(slender);
        EstablecerPunto(slender);
    }

    public void Botones(bool eleccion)
    {
        if (eleccion == true)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            Application.Quit();
        }
    }


    public void Aparecefinal(string texto)
    {
        panelFinal.SetActive(true);
        textoFinal.text = texto;

    }
}
