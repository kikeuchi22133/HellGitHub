using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
    public CAim         m_Aim;              //Aimクラス
    public CShot        m_Shot;             //Shotクラス
    public GameObject   m_Ball;             //ボールオブジェクト
    [SerializeField]
    private int         m_nBall;            //所持ボール
    [SerializeField]
    private int         m_nBallMax;         //所持ボール最大
    [SerializeField]
    private string      m_szAimObjectName;  //照準オブジェクトの名前
    [SerializeField]
    private string      m_szShotKeyName;    //ショットキーの名前
    [SerializeField]
    private bool        m_bShotTrigger;     //ショットトリガー

    void Start()
    {
        Init();
    }

    private void Update()
    {
        Shot();
    }

    //初期化
    private void Init()
    {
        m_Aim   = GameObject.Find(m_szAimObjectName).GetComponent<CAim>();
        m_Shot  = GetComponent<CShot>();

        m_nBall         = m_nBallMax;
        m_bShotTrigger  = false;
    }

    //ショット
    private void Shot()
    {
        m_bShotTrigger = m_Shot.ShotTrigger(m_szShotKeyName);
        if (m_bShotTrigger && 0 < m_nBall){
            m_nBall--;
            m_Shot.Shot(m_Ball, this.gameObject);
        }
    }

    //所持ボールのゲッター
    public int Ball()
    {
        return m_nBall;
    }

    //所持ボール最大のゲッター
    public int BallMax()
    {
        return m_nBallMax;
    }

}
