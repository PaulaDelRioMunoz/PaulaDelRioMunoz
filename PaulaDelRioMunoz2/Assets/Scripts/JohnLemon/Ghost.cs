using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //Variables
    [Header("WayPoints")]
    //"Arrays" de posiciones para patrulla
    [SerializeField]
    private Transform[] _positionsArray;
    [SerializeField]
    private float _speed;
    //Almacenar la posición a la que se dirige
    private Vector3 _posToGo;
    //Índice de posición
    private int _i;
    private Ray _ray;
    private RaycastHit _hit;

    public GameManager _GameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        
        _i = 0;
        _posToGo = _positionsArray[_i].position;

    }

    private void FixedUpdate()
    {

        DetectionJohnLemon();

    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
        ChangePosition();
        Rotate();

    }

    private void Move()
    {

        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);

    }

    private void ChangePosition()
    {
        //Si llega al destino
        if(Vector3.Distance(transform.position, _posToGo) <= Mathf.Epsilon)
        {

            //Comprobar si está en la última casilla del "array"
            if(_i == _positionsArray.Length - 1)
            {

                //vuelve a la casilla inicial
                _i = 0;

            }
            else
            {

                //Suma 1
                _i++;

            }
            
            _posToGo = _positionsArray[_i].position;

        }

    
    }
    
    private void Rotate()
    {

         transform.LookAt(_posToGo);
            
    }

    private void DetectionJohnLemon()
    {

        //Subir origen de ray 1m en eje Y respecto al pivote del objeto
        _ray.origin = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
        _ray.direction = transform.forward;

        if(Physics.Raycast(_ray, out _hit))
        {

            if(_hit.collider.CompareTag("JohnLemon"))
            {

                Debug.Log("¡Booo!");
                _GameManagerScript.IsPlayerCaught = true;

            }

        }

    }

        
}
