using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCuboA : MonoBehaviour
{
    public GameObject CuboPrefaab;
    private void Awake()
    {
        GameObject Cubito = Instantiate<GameObject>(CuboPrefaab);
        Cubito.transform.position = new Vector3(3,3,-4);
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
