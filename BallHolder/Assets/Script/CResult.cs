using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CResult : MonoBehaviour
{
    public CBasket m_1PlayerBasket;
    public CBasket m_2PlayerBasket;
    [SerializeField]
    private string m_sz1PlayerBasketName;
    [SerializeField]
    private string m_sz2PlayerBasketName;

    [SerializeField]
    private static CResult m_Result;
    [SerializeField]
    private static int  m_n1PlayerBasket;   //1プレイヤーのかご
    [SerializeField]
    private static int  m_n2PlayerBasket;   //2プレイヤーのかご
    [SerializeField]
    private bool    m_bDraw;           //引き分け
    [SerializeField]
    private bool    m_b1PlayerWin;     //1Playerの勝利
    [SerializeField]
    private bool    m_b2PlayerWin;     //2Playerの勝利
    [SerializeField]
    private Text    m_TextShow;         //テキスト表示
    [SerializeField]
    private string  m_szDraw;           //テキスト：引き分け
    [SerializeField]
    private string  m_sz1PlayerWin;     //テキスト：1プレイヤー勝利
    [SerializeField]
    private string  m_sz2PlayerWin;     //テキスト：2プレイヤー勝利
   
    void Start()
    {
        Init();
        Result();
    }

    void Update()
    {
        
    }

    //初期化
    private void Init()
    {
        m_1PlayerBasket = GameObject.Find(m_sz1PlayerBasketName).GetComponent<CBasket>();
        m_2PlayerBasket = GameObject.Find(m_sz2PlayerBasketName).GetComponent<CBasket>();

        m_Result = this;
        m_n1PlayerBasket    = 0;
        m_n2PlayerBasket    = 0;
        m_b1PlayerWin       = false;
        m_b2PlayerWin       = false;
        m_bDraw             = false;
        m_TextShow          = null;
    }
    
    //結果
    private void Result()
    {
        if (m_n1PlayerBasket == m_n2PlayerBasket){
            m_TextShow.text = m_szDraw;
        }
        else if (m_n1PlayerBasket > m_n2PlayerBasket){
            m_TextShow.text = m_sz1PlayerWin;
        }
        else{
            m_TextShow.text = m_sz2PlayerWin;
        }
    }

    private void BasketUpdate()
    {
        m_n1PlayerBasket = m_1PlayerBasket.BallCount();
        m_n2PlayerBasket = m_2PlayerBasket.BallCount();
    }
}
