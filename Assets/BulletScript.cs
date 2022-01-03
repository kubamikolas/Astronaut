using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulletScript : MonoBehaviour
{
    public int damage = 10;
     public int Respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D Col)
    {
        Destroy(this.gameObject);
    }
   void OnCollisionEnter(Collision col)
{
    // check If you collide with the player
    // I dont remember if you check it with col.tag - needs checking
    
}
}
