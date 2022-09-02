using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class fpsinput : MonoBehaviour
{
    public float _speed = 7f;
    public float _gravity = -9.8f;

    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        var deltaX = Input.GetAxis("Horizontal") * _speed;
        var deltaZ = Input.GetAxis("Vertical") * _speed;
        var motion = new Vector3(deltaX, 0, deltaZ);
        motion = Vector3.ClampMagnitude(motion, _speed);
        motion.y = _gravity;
        motion *= Time.deltaTime;
        motion = transform.TransformDirection(motion);
        _controller.Move(motion);
    }
}
