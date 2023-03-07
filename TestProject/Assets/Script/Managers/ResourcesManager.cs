using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager
{

    public Object Load(string path) 
    {
        return Resources.Load(path);
    }

    public Object Instantiate(string path)
    {
        Object prefab = Load($"Prefabs/{path}");
        if (prefab == null)
        {
            Debug.Log($"Filed to load prefab : {path}");
            return null;
        }

        return Object.Instantiate(prefab);
    }
    public void Destroy(GameObject go)
    {
        if (go == null)
        {
            return;
        }
        Destroy(go);
    }

}
