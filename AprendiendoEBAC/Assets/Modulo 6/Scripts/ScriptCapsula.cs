using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCapsula : MonoBehaviour
{
    public bool CambioColor2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var meshrendermaterial = GetComponent<MeshRenderer>().material;
        //Color c = new Color(Random.value, Random.value, Random.value);
        //meshrendermaterial.color = c;
    }
    private void FixedUpdate()
    {
        if (CambioColor2)
        {
            CambioColor2 = false;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.white;
            meshrendermaterial.color = c;
        }
        else
        {
            CambioColor2 = true;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.black;
            meshrendermaterial.color = c;
        }
    }
}
