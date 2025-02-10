using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JeuxBille : MonoBehaviour




{
    [SerializeReference] private GameObject _plateforme;
    // Start is called before the first frame update
    void Start()
    {
 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       public void DetruirePlateforme()
        {
            _plateforme.SetActive(false);
        }
 

}