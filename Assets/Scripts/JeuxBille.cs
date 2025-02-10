using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JeuxBille : MonoBehaviour




{
    private float resetTemps = 5f;
    private float Temps;

    private bool Decompte = false;
    [SerializeReference] private GameObject _plateforme;
    // Start is called before the first frame update
      void OnCollisionEnter(Collision collision)
      {
        if(collision.gameObject.CompareTag("Terminus"))
        {
            Decompte = true;
        }
      }
    void Start()
    {
       Temps = resetTemps;
 
    }

    // Update is called once per frame
    void Update()
    {
          if(Decompte)
          {
            Temps -= Time.deltaTime;
            if(Temps<=0)
            {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             Debug.Log(Temps);
            }
    }

        
    }
    
       public void DetruirePlateforme()
        {
            _plateforme.SetActive(false);
        }
}