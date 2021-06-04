using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    [SerializeField] GameObject GM;
    private int id = 000;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GM.GetComponent<FiguresNItem>().ApplyArtifact2Player(id); //캐릭터(rigidbody2D를 가진 애)가 먹으면 게임매니저에게 값 전달(id)
        Destroy(gameObject); //게임 오브젝트 소멸
    }

    void Start()
    {
        id = GM.GetComponent<FiguresNItem>().RandArti();// 1. 등급과 아티팩트 id 정하는 함수 호출 및 저장
        //Debug.Log(id);
        GM.GetComponent<FiguresNItem>().ApplySprite(id, GetComponent<SpriteRenderer>()); // 2. 해당 id 에 맞는 스프라이트로 변경
    }
}
