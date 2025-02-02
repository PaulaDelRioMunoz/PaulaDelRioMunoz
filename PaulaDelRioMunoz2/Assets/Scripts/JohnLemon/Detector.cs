using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    //Variables
    public GameManager _GameManagerScript;

    private void OnTriggerEnter(Collider infoAccess)
    {
        
        if (infoAccess.CompareTag("JohnLemon"))
        {

            Debug.Log("¡Alto ahí!");
            _GameManagerScript.IsPlayerCaught = true;

        }

    }

}
