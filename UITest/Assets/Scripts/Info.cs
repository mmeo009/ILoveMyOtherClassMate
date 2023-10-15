using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Info : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public string info;                 // ������ �����ϴ� string��
    public string imageName;            // �̹��� �̸��� �����ϴ� string��
    public TMP_Text text;               // ������ ����� tmp
    public Image image;                 // �̹����� ����� image
    public GameObject turretGrid;
    public UiShow ui;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject _turret = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Turret"));
        _turret.transform.parent = turretGrid.transform;
        _turret.transform.localPosition = Vector3.zero;
        ui.ShowUI();
    }

    public void OnPointerEnter(PointerEventData eventData)          // ���콺�� �� ������Ʈ ���� ��������
    {
        text.text = info;                                           // ������ ����� �ؽ�Ʈ�� ���� ������ �ִ� �ؽ�Ʈ ���� �־���
        image.sprite = Resources.Load<Sprite>($"{imageName}");      // �̹����� Resources/�̹����̸�(imageName ������ ������ �ִ� �̸�)�� ��������Ʈ ������ �ҷ���
    }

    public void OnPointerExit(PointerEventData eventData)           // ���콺�� �� ������Ʈ ������ ��������
    {
        text.text = "";                                             // �ؽ�Ʈ ����
        image.sprite = null;                                        // �̹����� null�� �ٲ�(�̹��� ����)
    }
}
