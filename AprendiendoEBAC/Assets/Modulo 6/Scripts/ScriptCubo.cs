using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo : MonoBehaviour
{

    private void Awake()
    {
        var meshrendermaterial = GetComponent<MeshRenderer>().material;
        Color c = new Color(Random.value, Random.value,Random.value);
        meshrendermaterial.color = c;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
