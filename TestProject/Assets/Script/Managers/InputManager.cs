using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{



    public Action KeyAction = null;
    public void OnUpdate()
    {
        if (Input.anyKey == false)  //�ƹ�Ű�� �ȴ����� ������
        {
            return;
        }
        else  // �ƹ�Ű������ �������� �Ʒ� ����
        {

            if (KeyAction != null)  // �Ű���� �����ְ� ��������Ʈ�� null�� �ƴ϶�� �Ʒ� ����
            {

                KeyAction.Invoke();  //��������Ʈ�� ����ִ� ��� �޼��带 ������Ѷ�
            }
        }
    }
}
