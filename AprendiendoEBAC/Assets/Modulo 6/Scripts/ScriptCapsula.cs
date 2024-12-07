using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCapsula : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var meshrendermaterial = GetComponent<MeshRenderer>().material;
        Color c = new Color(Random.value, Random.value, Random.value);
        meshrendermaterial.color = c;
    }
}
