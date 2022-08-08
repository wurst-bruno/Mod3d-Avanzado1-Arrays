using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArrays : MonoBehaviour
{
    public int[] numeros;
    private GameObject[] otrosNumeros = new GameObject[3];
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numeros[0]);
        Debug.Log(otrosNumeros[0]);
        //escribir primer elemnto del array
        Debug.Log(nombre[0]);
        //escribir ultimo elemnto del array
        Debug.Log(nombre[nombre.Length - 1]);

        escribirletraporletramenoslaso(nombre);
        existeletraencadena(nombre, 'x');
        escribircadenainvertida(nombre);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void escribirletraporletramenoslaso(string cadena)
    {
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] != 'o')
            {
                Debug.Log(cadena[i]);
            }
        }

    }


    void escribirletraporletra(string cadena)
    {
        for (int i = 0; i < cadena.Length; i++)
        {
            if (i == 3)
            {
                i++;
            }
            Debug.Log(cadena[i]);
        }

    }

    void existeletraencadena(string cadena, char letrabuscada)
    {
        bool letraecontrada = false;
        int counter = 0;
        while (!letraecontrada && counter < cadena.Length)
        {
            if (cadena[counter] == letrabuscada)
            {
                letraecontrada = true;
                Debug.Log("Existe la letra en la posicion " + counter);
            }

            counter++;
        }
        if (counter >= cadena.Length)
        {
           Debug.Log("No existe la letra en la cadena");
        }
    }

    void escribircadenainvertida(string cadena)
    {
        for (int i = cadena.Length -1; i >= 0; i--)
        {
            Debug.Log(cadena[i]);
        }
    }
}
