using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBall : MonoBehaviour
{
    public CPlayer  m_Player;               //Playerクラス
    [SerializeField]
    private string  m_szPlayerObjectName;   //プレイヤーオブジェクトの名前
    [SerializeField]
    private float   m_fMoveSpeed;           //ボールの移動速度

    private void Start()
    {
        Init();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    //初期化
    private void Init()
    {
        m_Player = GameObject.Find(m_szPlayerObjectName).GetComponent<CPlayer>();
        GetComponent<Rigidbody2D>().velocity = m_Player.m_Aim.Direction() * m_fMoveSpeed;
    }
}
