using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  //DoTween을 사용하기 위해 추가

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        //Tween단위
        // tween = transform.DOMoveX(5,2);                      //이 오브젝트를 2초 동안 X축 5로 이동시킨다
        //transform.DORotate(new Vector3(0,0,180),2);   //이 오브젝트를 2초 동안 Z축으로 180도 회전 시킨다.
        //transform.DOScale(new Vector3(2,2,2),2);        // 이 오브젝트를 2초동안 Scale이 2가 되도록 키운다.

        //전체 주석 및 주석 해제 Ctrl + K + C, Ctrl + K + U
        //Sequence sequence=DOTween.Sequence();                   //Tween을 이어서 순서대로 실행 시켜주는 단위
        //sequence.Append(transform.DOMoveX(5,2));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sequence.Append(transform.DOScale(new Vector3(2,2,2),2));

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce);    //Ease 옵션을 사용하여 바운스 효과 적용
        //transform.DOShakeRotation(2f, new Vector3(0, 0, 90), 10, 90);  // 회전을 Z축 90도 강도는 10, 랜덤 90으로 힘을 준다.

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);  //트윈이 완료도면 Tween End 함수를 호출한다.

        sequence = DOTween.Sequence();                   //Tween을 이어서 순서대로 실행 시켜주는 단위
        sequence.Append(transform.DOMoveX(5, 1));                 //Tween실행
        sequence.SetLoops(-1, LoopType.Yoyo);                     //Tween 요요형태로 반복 시킨다.
    } 

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween.Kill;
        }
    }
}
