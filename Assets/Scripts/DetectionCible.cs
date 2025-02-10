using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCible : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    }
}