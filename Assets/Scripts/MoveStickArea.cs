using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveStickArea : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject stickBack;
    [SerializeField] private GameObject stick;
    [SerializeField] private Player player;

    private Vector3 startPos;
    private Vector3 moveVec;
    private float moveDis;
    private float stickBackRadius;

    void Start()
    {
        Init();
        startPos = transform.position;
        stickBackRadius = stickBack.GetComponent<RectTransform>().rect.width / 2f;

        stickBack.SetActive(false);
    }

    void Init()
    {
        startPos = Vector3.zero;
        moveVec = Vector3.zero;
        moveDis = 0;
    }

    public void OnTouch(Vector2 vecTouch)
    {
        player.Move(moveVec * moveDis / 5);
    }

    public void OnPointerDown(PointerEventData touchData)
    {
        stickBack.SetActive(true);
        stickBack.transform.position = touchData.position;
        startPos = touchData.position;
    }

    public void OnDrag(PointerEventData touchData)
    {
        Vector3 pos = touchData.position;
        moveVec = (pos - startPos).normalized;
        moveDis = Vector3.Distance(pos, startPos);

        if(moveDis > stickBackRadius)
            moveDis = stickBackRadius;

        stick.transform.position = startPos + moveVec * moveDis;
    }

    public void OnPointerUp(PointerEventData touchData)
    {
        Init();
        stickBack.transform.localPosition = Vector3.zero;
        stick.transform.localPosition = Vector3.zero;
        stickBack.SetActive(false);
    }


}
