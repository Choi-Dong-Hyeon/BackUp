using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static public Managers instance; //스크립트cs
    public static Managers Instance
    {
        get
        {
            Init();
            return instance;
        }
    }
    static void Init() //빈오브젝트를 생성해서 움직임 스크립트를 넣는다
    {
        if (instance == null)
        {
            GameObject go = GameObject.Find("ManagersTest");
            if (go == null)
            {
                go = new GameObject { name = "ManagersTest" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            instance = go.GetComponent<Managers>();
        }
    }

    void Start()
    {
        Init();

    }

    InputManager inputmanager = new InputManager();
    public static InputManager Inputmanager
    {
        get
        {
            return Instance.inputmanager;

        }
    }




    void LateUpdate()
    {
        inputmanager.OnUpdate();  //매프레임 마다 움직임이 있는지 없는지 확인을한다



    }



      ResourcesManager resource = new ResourcesManager();
    public static ResourcesManager Resource
    {
        get{
            return Instance.resource;

        }
    }


}
