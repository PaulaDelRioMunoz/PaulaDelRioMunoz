using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    //Variables
    //Referencia al prefab
    [SerializeField]
    private GameObject _shellPrefab;
    //Referencia al objeto vacio, posición de salida
    [SerializeField]
    private Transform _posShell;
    //Fuerza a la que sale la bala
    [SerializeField]
    private float _launchForce;
    //Referencia al AudioSource del _posShell
    [SerializeField]
    private AudioSource _audioSource;

    // Update is called once per frame
    void Update()
    {

        InputPlayer();
        
    }

    private void InputPlayer()
    {

        if(Input.GetMouseButtonDown(0))
        {

            Launch();

        }

    }

    private void Launch()
    {

        GameObject cloneShellPrefab = Instantiate(_shellPrefab, _posShell.position, _posShell.rotation);

        _audioSource.Play();

        cloneShellPrefab.GetComponent<Rigidbody>().velocity = _posShell.forward * _launchForce;
        
    }
}
