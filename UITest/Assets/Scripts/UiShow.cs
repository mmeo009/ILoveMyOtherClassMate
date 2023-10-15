using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiShow : MonoBehaviour
{
    public GameObject ui;           // �츮�� ���� �״� �� ������Ʈ
    bool uiActive = false;          // ���� �״� �� bool ������

    public void Awake()
    {
        ui.SetActive(uiActive);     // awake(Ȥ�� start)���� ������Ʈ�� Ȱ�� ���¸� bool�� ������ ����
    }
    public void ShowUI()            // ��ư�� ���� �Լ�
    {
        uiActive = !uiActive;       // �Ұ��� �ݴ�� (true => false, false => true)
        ui.SetActive(uiActive);     // �ٲ� ���� ���� ������Ʈ�� Ȱ�� ���¿� ����
    }
}
