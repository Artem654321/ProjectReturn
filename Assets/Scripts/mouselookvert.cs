using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselookvert : MonoBehaviour
{
    private float _sensetivityVert = 9.0f;
    private float _minimumVert = -45.0f;
    private float _maximumVert = 45.0f;

    private float _rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * _sensetivityVert;
        _rotationX = Mathf.Clamp(_rotationX, _minimumVert, _maximumVert);
        var rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
    }
}
