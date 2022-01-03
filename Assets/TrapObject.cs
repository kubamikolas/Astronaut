using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class TrapObject : MonoBehaviour
{
public int Respawn;

    private void Reset() {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag =="Player")
        {
            

            SceneManager.LoadScene(Respawn);
            
        }
    }
}
