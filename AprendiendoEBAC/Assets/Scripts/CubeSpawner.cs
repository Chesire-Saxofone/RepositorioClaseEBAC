using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> ListadeCubos;
    public float factordeescalamiento;
    public int numcubos;
    // Start is called before the first frame update
    void Start()
    {
        ListadeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numcubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        tempGameObject.name = "Cubo Numero" + numcubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        ListadeCubos.Add(tempGameObject);
        List<GameObject> ObjetosparaEliminar = new List<GameObject>();
        foreach (GameObject go in ListadeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factordeescalamiento;
            go.transform.localScale = Vector3.one * scale;
            
            if (scale <= 0.1)
            {
                ObjetosparaEliminar.Add(go);
            }
        }
        foreach (GameObject go in ObjetosparaEliminar)
        {
            ListadeCubos.Remove(go);
            Destroy(go);
        }
    }
}