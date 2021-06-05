using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveStickArea : MonoBehaviour
{
    [SerializeField] private GameObject stickBack;
    [SerializeField] private GameObject stick;
    [SerializeField] private Player player;
    [SerializeField] private GameObject Camera;

    private Vector3 startPos;
    private Vector3 moveVec;
    private float moveDis;
    private float stickBackRadius;
    private bool isMoving;

    void Start()
    {
        Init();
        startPos = transform.position;
        stickBackRadius = stickBack.GetComponent<RectTransform>().rect.width / 2f;
        //Debug.Log(stickBackRadius);

        stickBack.SetActive(false);
    }

    void Update()
    {
        if (isMoving)
        {
<<<<<<< HEAD
            player.Move(moveVec * moveDis / 10); 
            Camera.GetComponent<LeadCamera>().recieveRot(moveVec*moveDis/16);
=======
            //Debug.Log(moveDis);
            player.Move(moveVec * moveDis / 10);
>>>>>>> 작업중인내용(명준2)
        }
    }

    void Init()
    {
        startPos = Vector3.zero;
        moveVec = Vector3.zero;
        moveDis = 0;
        isMoving = false;
    }

    public void BeginDrag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 touchPos = Data.position;

        stickBack.SetActive(true);
        stickBack.transform.position = touchPos;
        startPos = touchPos;
        isMoving = true;
    }

    public void OnDrag(BaseEventData _Data)
    {
        PointerEventData Data = _Data as PointerEventData;
        Vector3 pos = Data.position;

        moveVec = (pos - startPos).normalized;
        moveDis = Vector3.Distance(pos, startPos);

        if(moveDis > stickBackRadius)
            moveDis = stickBackRadius;

        stick.transform.position = startPos + moveVec * moveDis;
    }

    public void EndDrag()
    {
        Init();
        stickBack.transform.localPosition = Vector3.zero;
        stick.transform.localPosition = Vector3.zero;
        stickBack.SetActive(false);
        Camera.GetComponent<LeadCamera>().recieveRot(new Vector3(0,0,0));
    }
}
