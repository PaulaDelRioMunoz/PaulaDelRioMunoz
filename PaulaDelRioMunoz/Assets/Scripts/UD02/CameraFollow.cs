using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Variables
    public Transform Target;

    //Velocidad de seguimiento
    private float _smoothing;

    //Distancia entre "target" y "camara"
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        
        //("offset" = posicion de camara - la del "player") = Vector que los une
        _offset = transform.position - Target.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        //Donde quiero la camara
        Vector3 camPosition = Target.position + _offset;
        transform.position = camPosition;

    }
}
