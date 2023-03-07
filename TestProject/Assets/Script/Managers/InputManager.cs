using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{



    public Action KeyAction = null;
    public void OnUpdate()
    {
        if (Input.anyKey == false)  //아무키도 안눌리면 가만히
        {
            return;
        }
        else  // 아무키던간에 눌렸으면 아래 진입
        {

            if (KeyAction != null)  // 어떤키던간 눌려있고 델리게이트가 null이 아니라면 아래 진입
            {

                KeyAction.Invoke();  //델리게이트에 들어있는 모든 메서드를 실행시켜라
            }
        }
    }
}
