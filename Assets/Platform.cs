using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
  private Vector3 posA;

  private Vector3 posB;

  private Vector3 nexPos;

    [SerializeField]
     private float speed;

    [SerializeField]
    private Transform childTransform;
    
    [SerializeField]
    private Transform transformB;
    
    void Start()
    {
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        nexPos = posB;
    }

    void Update(){
        Move();

    }


    private void Move()
  {

      childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);
        if (Vector3.Distance(childTransform.localPosition, nexPos) <= 0.1)
  {
      ChangeDestionation();
  }
  }
  private void ChangeDestionation()
      {
          nexPos = nexPos !=posA ? posA : posB;
      }
  
}
