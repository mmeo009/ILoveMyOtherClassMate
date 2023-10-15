using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiShow : MonoBehaviour
{
    public GameObject ui;           // 우리가 껐다 켰다 할 오브젝트
    bool uiActive = false;          // 껐다 켰다 할 bool 형변수

    public void Awake()
    {
        ui.SetActive(uiActive);     // awake(혹은 start)에서 오브젝트의 활성 상태를 bool형 변수로 변경
    }
    public void ShowUI()            // 버튼에 넣을 함수
    {
        uiActive = !uiActive;       // 불값을 반대로 (true => false, false => true)
        ui.SetActive(uiActive);     // 바뀐 변수 값을 오브젝트의 활성 상태에 대입
    }
}
