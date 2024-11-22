using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPLayer : MonoBehaviour
{
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;
    
    private Animator _anim;
    private Rigidbody _rb;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                 _canPlayerJump;
    
    [Header("Raycast")]
    //Capa donde actúa el "raycast"
    public LayerMask SueloMask;
    //Longitud del "raycast"
    public float RayLength;

    [Header("Jump")]
    public float JumpForce;

    public Transform Checker;
    
    private void Awake()
    {
        //La varibale "anim" apunta al componente Animator
        // del "gameObject" que lleve este "script"
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        InputPlayer();
        Move();
        CanJump();
        Animating();
        Ataca();

    }

    private void FixedUpdate()
    {

        LaunchRaycast();
        if(_canPlayerJump)
        {

            _canPlayerJump = false;
            //llamar al metodo "jump"
            Jump();
        }

    }

    private void LaunchRaycast()
    {
        //El punto de pivote
        _ray.origin = Checker.position;
        //Hacia abajo
        _ray.direction = -transform.up;

        if(Physics.Raycast(_ray, out _hit, RayLength))
        {
            //Puedo saltar
            _isGrounded = true;
            Debug.Log("Toco el suelo");

        }
        else
        {

            _isGrounded = false;

        }

        Debug.DrawRay(_ray.origin, _ray.direction * RayLength, Color.red);
    }

    private bool CanJump()
    {

        //Si quiero y puedo saltar
        if(Input.GetKey(KeyCode.Space) && _isGrounded)
        {

            _canPlayerJump = true;
            return true;
        }

        _anim.SetBool("Salta", false);

        return false;
        
    }

    private void Jump()
    {
         _anim.SetBool("Salta", true);

        _rb.AddForce(Vector3.up * JumpForce);
    }

    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        if(Input.GetKey (KeyCode.E))
        {

            transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);

        }

        if(Input.GetKey (KeyCode.Q))
        {

            transform.Rotate(Vector3.up * -_turnSpeed * Time.deltaTime);

        }

    }

    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
        transform.Translate(Vector3.right * _speed * _horizontal * Time.deltaTime);

    }

    private void Animating()
    {

        if(_vertical !=0)//El personaje se esta moviendo
        {
            
            _anim.SetBool("SeMueve", true);

        }
        else //vertical = 0, el personaje esta parado
        {

            _anim.SetBool("SeMueve", false);

        }

        
    }

    private void Ataca()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            //Ejecuta la animacion
            _anim.SetBool("Ataca", true);

        }
        else
        {

            _anim.SetBool("Ataca", false);

        }

        

        
    }

}