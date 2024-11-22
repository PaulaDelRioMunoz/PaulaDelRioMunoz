using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider infoAccess)
    {

        if (infoAccess.CompareTag("AtaqueFlores"))
        {

            Destroy(gameObject);

        }
        
    }
}
