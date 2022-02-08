using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]

    [Tooltip("the axis around which the gameObject rotating")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;
    [Tooltip("the axis around which the gameObject rotating. Measured in degrees/frame")]
    [SerializeField]
    private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
