using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselookhor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float _sensetivityHor = 9.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * _sensetivityHor, 0);
    }
}
