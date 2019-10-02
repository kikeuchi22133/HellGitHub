using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerStatus : MonoBehaviour
{
    [SerializeField]
    private CPlayer m_Player;               //プレイヤークラス
    [SerializeField]
    private string  m_szPlayerObjectName;   //プレイヤーオブジェクトの名前
    [SerializeField]
    private Text    m_TextBall;             //テキスト：所持ボール
    [SerializeField]
    private Text    m_TextBallMax;          //テキスト：所持ボール最大
    void Start()
    {
        Init();
    }

    void Update()
    {
        TextBallUpdate();
    }

    //初期化
    private void Init()
    {
        m_Player = GameObject.Find(m_szPlayerObjectName).GetComponent<CPlayer>();
        m_TextBall.text     = m_Player.Ball().ToString();
        m_TextBallMax.text  = m_Player.BallMax().ToString();
    }

    //テキストボールの更新
    private void TextBallUpdate()
    {
        m_TextBall.text     = m_Player.Ball().ToString();
    }
}
