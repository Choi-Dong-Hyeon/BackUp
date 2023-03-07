using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    Object prefab;
    Object Tang;
    void Start()
    {
       Tang= Managers.Resource.Instantiate("Tang");
      //  prefab = Resources.Load("Prefabs/Tang");
       // Tang = Instantiate(prefab);
        Destroy(Tang,4f );
    }


   
    void Update()
    {
        
    }
}
