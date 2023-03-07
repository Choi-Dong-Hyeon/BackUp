using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static public Managers instance; //��ũ��Ʈcs
    public static Managers Instance
    {
        get
        {
            Init();
            return instance;
        }
    }
    static void Init() //�������Ʈ�� �����ؼ� ������ ��ũ��Ʈ�� �ִ´�
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
        inputmanager.OnUpdate();  //�������� ���� �������� �ִ��� ������ Ȯ�����Ѵ�



    }



      ResourcesManager resource = new ResourcesManager();
    public static ResourcesManager Resource
    {
        get{
            return Instance.resource;

        }
    }


}
