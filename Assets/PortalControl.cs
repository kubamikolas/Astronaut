using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControl : MonoBehaviour
{
   public static PortalControl portalControlInstance;

   [SerializeField]
    private GameObject bluePortal, orangePortal;

    [SerializeField]
    private Transform bluePortalSpawnPoint, orangePortalSpawnPoint;

    private Collider2D bluePortalCollider, orangePortalCollider;

    [SerializeField]
    private GameObject clone;

    void Start()
    {
        portalControlInstance = this;
        bluePortalCollider = bluePortal.GetComponent<Collider2D>();
        orangePortalCollider = orangePortal.GetComponent<Collider2D>();
        
    }

    public void CreateClone(string whereToCreate)
    {
        if (whereToCreate == "atBlue")
        {
            var instantiatedClone = Instantiate(clone, bluePortalSpawnPoint.position, Quaternion.identity);
            instantiatedClone.gameObject.name = "Clone";        
        }
    }

    public void DisableCollider(string colliderToDisable)
    {
        if (colliderToDisable == "orange")
        {
            orangePortalCollider.enabled = false;
        } else 
        if (colliderToDisable == "blue")
        {
            bluePortalCollider.enabled = false;

        }
    }
    public void EnableColliders()
        {
            orangePortalCollider.enabled = true;
            bluePortalCollider.enabled = true;

        }


    }

























