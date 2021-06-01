using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiguresNItem : MonoBehaviour
{
    int mHealth = 125;
    int pHealth = 125;
    int mMana = 125;
    float pMana = 125;
    float manaResen =25;
    int offenPoint=125;
    int defenPoint=0;
    int evaPoint=0;
    float charSpeed=0.5f;
    float charSize=100;
    int pGold=5;
    float goldDropRate=3;
    int pWizstone=2;
    float wizstoneDropRate=3;
    float chestAppearRate=5;
    float potionDropRate=5;
    int castingNum=1;


    public void ApplyArtifact(int id)
    {
        //id를 받아서, 캐릭터에게 적용시킴. 아이템별로 함수를 만들어서 여기에서 해당 함수 호출하면 될듯 (수치, 기능, 외형, 세트효과개수파악, 인벤토리스크립트에 아이템 ID 전달)
    }
    public void ApplyScroll(int id)
    {
        //id를 받아서, 캐릭터에게 적용시킴(해당 위즈 사용 가능으로 변경, 인벤토리스크립트에 위즈 ID 전달) 
    }
    public void ApplyETCitem(int id)
    {
       /* switch (id)
        {
            case 601 :
                Debug.Log(gameObject);
            case 602:


        }*/
        
        //체력포션, 마나포션, 골드, 위즈스톤 적용
    }

    public void healHPMP(int HorM,int value)
    {

    }


    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
