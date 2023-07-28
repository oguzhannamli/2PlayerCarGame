using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "FinishLine")
        {
            
         SceneManager.LoadScene("FinishScene"); 
            
          
            
        }
    }
}
