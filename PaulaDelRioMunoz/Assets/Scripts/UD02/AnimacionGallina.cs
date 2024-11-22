using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionGallina : MonoBehaviour
{

    private float _vertical;

    private Animator anim;

    private void Awake()
    {
        //Variable ""anim" apunta al componente Animator del "gameObject" que lleve el "script"
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        _vertical = Input.GetAxis("Vertical");
        Animating();

    }

    private void Animating()
    {

        if(_vertical != 0)//el personaje se mueve
        {

            anim.SetBool("SeMueve", true);

        }
        else//"_vertical es igual a 0, el personaje esta parado
        {

            anim.SetBool("SeMueve", false);

        }

    }

   
}
