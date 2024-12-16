using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaM11 : MonoBehaviour
{
    List<int> listaRandom = new List<int>();
    int[] miArreglo = new int[6] { 2, 4, 5, 6, 8, 12 };
    List<int> listaRepetida = new List<int> { 1, 2, 3, 4, 5, 5, 6, 1, 2, 7, 8, 9, 10 };
    Stack<string> pilaNombres = new Stack<string>();
    Queue<string> colaNombres = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {
        miFuncion(5, 3, 14);
        segundaFuncion(miArreglo);
        terceraFuncion(listaRepetida);
        pilaNombres.Push("Juan");
        pilaNombres.Push("Pablo");
        pilaNombres.Push("René");
        pilaNombres.Push("Luan");
        pilaNombres.Push("Nicolás");
        pilaNombres.Push("Tomas");
        pilaNombres.Push("Ricardo");
        cuartafuncion(pilaNombres);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        for (int i = 0; i < tamaño; i++)
        {
            listaRandom.Add(UnityEngine.Random.Range(rangoInferior, rangoSuperior));
            Debug.Log(listaRandom[i]);
        }
        return listaRandom;
    }

    public int[] segundaFuncion(int[] arregloEntrada)
    {
        Array.Sort(arregloEntrada, (a, b) => b.CompareTo(a));
        for (int i = 0; i < arregloEntrada.Length; i++)
        {
            Debug.Log(arregloEntrada[i]);
        }
        return arregloEntrada;
    }

    public HashSet<int> terceraFuncion(List<int> listaEntrada)
    {
        HashSet<int> numerosUnicos = new HashSet<int>(listaEntrada);
        foreach (int numeros in numerosUnicos)
            Debug.Log(numeros);
        return numerosUnicos;
        
    }
    public void cuartafuncion(Stack<string> nombres)
    {
        foreach(string nombresLectura in nombres)
        {
            colaNombres.Enqueue(nombresLectura);
            Debug.Log(nombresLectura);
        }
        foreach(string nombresCola  in colaNombres)
        {
            Debug.Log(nombresCola);
        }
    }
}

