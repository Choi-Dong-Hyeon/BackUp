using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        Managers.Inputmanager.KeyAction = OnKeyBoard;   //움직임코드를 델리게이트에 넣는다
    }

    [SerializeField] float speed = 3;
    void Update()
    {


    }

    void OnKeyBoard()
    {
       
        

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward.normalized * speed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.3f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.3f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.3f);
        }
    
}

}
