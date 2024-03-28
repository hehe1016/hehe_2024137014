using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null; //�ؽ�Ʈ UI
    public int Count = 0; //���콺 ų�� ī���� 
    public float Power = 100.0f; //���� �� ��ġ

    public int Point = 0; //���� ��ġ
    public float checkTime = 0.0f; //�ð� üũ ǥ��

    public Rigidbody m_Rigidbody; //������Ʈ�� ��ü


    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;                              //�ð��� �����ؼ� �״´�. checkTime -> 0��, 1��, 0��, 1��
        if(checkTime >=1.0f)                                      //1�ʸ��� � �ൿ�� �Ѵ�. 
        {
            Point += 1;                                           //1�ʸ��� ���� 1���� �ø���.
            checkTime = 0.0f;                                     //�ð��� �ʱ�ȭ �Ѵ�.
        }

        if (Input.GetKeyDown(KeyCode.Space))                     //�����̽��� ���� ��
        {
            Power = Random.Range(100, 200);                      //100~200 ������ ���� ���� �ش�.
            m_Rigidbody.AddForce(transform.up * Power);          //Y������ ������ ���� �ش�.
        }

        TextUI.text = Point.ToString();                          //UI�� ���� ǥ�ø� �Ѵ�.
    }
    void OnCollisionEnter (Collision collision)                  //�浹�� �Ǿ��� ��
    {
        //  Debug.Log(collision.gameObject.name);
        Point = 0;
        gameObject.transform.position = Vector3.zero;            //�÷��̾ �������� �̵� ��Ų��.
    }

}