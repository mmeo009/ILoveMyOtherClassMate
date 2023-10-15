using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Info : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public string info;                 // 정보를 저장하는 string값
    public string imageName;            // 이미지 이름을 저장하는 string값
    public TMP_Text text;               // 정보를 출력할 tmp
    public Image image;                 // 이미지를 출력할 image
    public GameObject turretGrid;
    public UiShow ui;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject _turret = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Turret"));
        _turret.transform.parent = turretGrid.transform;
        _turret.transform.localPosition = Vector3.zero;
        ui.ShowUI();
    }

    public void OnPointerEnter(PointerEventData eventData)          // 마우스가 이 오브젝트 내에 들어왔을때
    {
        text.text = info;                                           // 정보를 출력할 텍스트에 내가 가지고 있는 텍스트 값을 넣어줌
        image.sprite = Resources.Load<Sprite>($"{imageName}");      // 이미지에 Resources/이미지이름(imageName 변수가 가지고 있는 이름)의 스프라이트 파일을 불러옴
    }

    public void OnPointerExit(PointerEventData eventData)           // 마우스가 이 오브젝트 내에서 나갔을때
    {
        text.text = "";                                             // 텍스트 지움
        image.sprite = null;                                        // 이미지도 null로 바꿈(이미지 제거)
    }
}
