using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExSoundPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))                //1�� Ű���带 ������ ��
        {
            SoundManager.instance.PlaySound("BackGround");
        } 
        if (Input.GetKeyDown(KeyCode.Alpha2))               //2�� Ű���带 ������ ��
        {
            SoundManager.instance.PlaySound("Cannon");
        }
    }
}
