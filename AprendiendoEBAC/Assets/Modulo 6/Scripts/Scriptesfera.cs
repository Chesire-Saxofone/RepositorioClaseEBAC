using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptesfera : MonoBehaviour
{
    public bool CambioColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (CambioColor) { 
        CambioColor = false;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.white;
            meshrendermaterial.color = c;
        }
        else
        {
            CambioColor = true;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.black;
            meshrendermaterial.color = c;
        }

        //var meshrendermaterial = GetComponent<MeshRenderer>().material;
        //Color c = new Color(Random.value, Random.value, Random.value);
        //meshrendermaterial.color = c;
    }
}
