using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Vector3 look= transform.TransformDirection(Vector3.forward);
 
        Debug.DrawRay(transform.position+Vector3.up, look * 10, Color.red);

        RaycastHit[] hit2;
       hit2 = Physics.RaycastAll(transform.position, look,  10);


        if(Physics.Raycast(transform.position + Vector3.up, look,out hit, 10))
        {
            
            Debug.Log(hit.collider.name);
        }
       
    }
}
