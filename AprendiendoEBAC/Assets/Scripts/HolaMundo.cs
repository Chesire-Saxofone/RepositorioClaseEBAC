using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        Debug.Log("Estoy siendo llamado desde awake");
    }
    void Start()
    {
        Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Estoy siendo llamado desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Estoy siendo llamado desde fixedupdate");
    }
    private void LateUpdate()
    {
        Debug.Log("Estoy siendo llamado desde late update");
    }
}
