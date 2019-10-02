using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBasket : MonoBehaviour
{
    [SerializeField]
    private int m_nBallCount;          //ボールが入った数
    [SerializeField]
    private int m_nBallCountMax;  //ボールのカウント最大値

    private void Start()
    {
        Init();
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        BallCount(Collision);
    }

    //初期化
    private void Init()
    {
        m_nBallCount = 0;
    }

    //ボールカウント
    private void BallCount(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Ball")){
            if (m_nBallCount < m_nBallCountMax){
                m_nBallCount++;
            }
        }
    }

    public int BallCount()
    {
        return m_nBallCount;
    }
}
