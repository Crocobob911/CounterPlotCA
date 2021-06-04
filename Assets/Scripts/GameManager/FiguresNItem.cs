using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresNItem : MonoBehaviour
{
    [SerializeField] Sprite sample;
    [SerializeField] GameObject player;
    int mHealth = 125;
    int pHealth = 125;
    int mMana = 125;
    float pMana = 125;
    float manaResen =25;
    //int offenPoint=125;
    //int defenPoint=0;
    //int evaPoint=0;
    //float charSpeed=0.5f;
    //float charSize=100;
    int pGold=5;
    int goldDropRate= 10;         //max :20
    int ThreeGoldDropRate = 10;
    int pWizstone=2;
    int wizstoneDropRate= 5;    //max : 10
    int chestAppearRate= 3;     //max : 10
    int HPpotionDropRate= 5;    //max : 10
    int BigHPotionDropRate = 10; //일단은 고정치
    int MPpotionDropRate = 5;   //max : 10
    //int castingNum=1;
    

    public void AppearArti() //아티팩트 등장
    {
        //아티팩트 생성
    }
    public int RandArti()
    {
        int id = 0, rarity = 0, randInt=0;

        // 아티팩트 등급 결정 부분
        randInt = Random.Range(0, 100);
        if      (randInt < 55)  rarity = 0;  //일반 : 55%
        else if (randInt < 80)  rarity = 0;  //레어 : 25%
        else if (randInt < 95)  rarity = 0;  //에픽 : 15%
        else                    rarity = 0;  //전설 : 5%
        
        // 동일 등급 내, 아티팩트 id 결정 함수

        switch (rarity)
        {
            case 0:
                //id = Random.Range(001,100);
                id = 000;
                break;
            case 1:
                //id = Random.Range(101, 200);
                id = 000;
                break;
            case 2:
                //id = Random.Range(201, 300);
                id = 000;
                break;
            case 3:
                //id = Random.Range(301, 306);
                id = 000;
                break;
        }
        
        return id;
    }  //아티팩트 등장 시(상자, 상점, 유적 클리어 등) 등급과 아티팩트 id 결정부분

    public void AppearScroll() // 스크롤 등장
    {
        //스크롤 생성
    }
    public int RandScroll() //스크롤 등장 시(상점, 유적클리어 등) 등급과 위즈 id 결정부분
    {
        int id = 0;
        return id;
    }

    public void AppearETCitem(int monsterType, Vector2 position) // 0 일반몬스터 1 엘리트 몬스터  // 엘리트 몬스터면 꽝 확률 -20%
    {
        int randNum = Random.Range(0,100-(monsterType*20));
        if (0 <= randNum && randNum <= 0 + HPpotionDropRate) //체력포션 0~10
        {
            if (Percent(BigHPotionDropRate))
            {
                //대형 체력포션 등장 
                return;
            }
            //일반 체력포션 등장
            return;
        }
        else if (11 <= randNum && randNum <= 11 + MPpotionDropRate) //마나포션 11~20 
        {
            //마나포션 등장
            return;
        }
        else if (21 <= randNum && randNum <= 21 + goldDropRate) //골드 21~40
        {
            if (Percent(ThreeGoldDropRate))
            {
                //골드 묶음(3개) 등장 
                return;
            }
            //골드 1개 등장
            return;
        }
        else if (41 <= randNum && randNum <= 41 + wizstoneDropRate) //위즈스톤 41~50
        {
            //위즈스톤 1개 등장
            return;
        }
        // 51~99 사이의 수 가 나오거나, 각 if 부분에서 n+droprate에 해당하지 못하는 부분에 걸리면 꽝


    } // 몬스터 사망 시, 상자 오픈 시(?)_일단은// 기타 아이템 등장 확률
    public void AppearBox1(Vector2 position)
    {

        if (true)
        {
            //상자 나올 확률 100
        }
        else
        {
            if (Percent(chestAppearRate))
            {
                //상자 생성
            }
            else return;
            //상자 나올 확률은 수치에 따라 달라짐
        }
    }

    public void ApplySprite(int id, SpriteRenderer sp)
    {
        // SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
        // Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Player/Player01");
        // spriteR.sprite = sprites[0];
        if (id == 000)
            sp.sprite = sample;
    } // 모든 아이템 등장 시 스프라이트 적용(필드에 등장 or 인벤에 표현)

    public void ApplyArtifact2Player(int id)
    {
        switch (id)
        {
            case 000:
                //sampleitem()~
                player.GetComponent<Transform>().position = new Vector3(0, 0, 0);
                break;
        }
        //id를 받아서, 캐릭터에게 적용시킴. 아이템별로 함수를 만들어서 여기에서 해당 함수 호출하면 될듯 (수치, 기능, 외형, 세트효과개수파악, 인벤토리스크립트에 아이템 ID 전달)
    } //아티팩트 획득 시 플레이어 수치 변경, 인벤토리 이동, 외형 변경부
    public void ApplyScroll2Player(int id) // 스크롤 획득 시 위즈 사용 가능으로 변경 및 인벤토리 이동
    {
        
    }
    public void ApplyETCitem(int id)
    {
       switch (id)
        {
            case 601 :
                pHealth += 100; // 체력포션 (대)
                break;
            case 602 :
                pHealth += 50; // 체력포션 (소)
                break;
            case 603 :
                pMana = mMana; // 마나포션 
                break;
            case 604 :
                pGold += 10;    //골드 10개
                break;
            case 605:
                pGold += 5;     //골드 5개
                break;
            case 606:
                pGold += 1;     //골드 1개
                break;
            case 607:
                pWizstone++;    //위즈스톤 1개
                break;
        }
        
        //체력포션, 마나포션, 골드, 위즈스톤 적용
    } // 기타 아이템 획득 시 플레이어, 골드 개수 등 수치 변경
    
    private bool Percent(int r)
    {
        int randNum = Random.Range(0, 100);
        if(randNum < r)
            return true;
        return false;
    } //퍼센트 계산기
    private bool IsPlayerHiddenArea()
    {
        if (true)//gameobject.GetComponent<유틸리티 시스템 관리(맵 생성, 포탈 이동 등)>().플레이어 위치가 어딘가요?() == 1 //0: 일반구역, 1:히든구역 ~~등
            return true;
        return false;
    }





    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
