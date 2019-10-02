using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAim : MonoBehaviour
{
    [SerializeField]
    private float   m_fAngle;           //角度
    [SerializeField]
    private float   m_fAngleMax;        //最大角度
    [SerializeField]
    private float   m_fAngleMin;        //最小角度
    [SerializeField]
    private float   m_fStartAngle;      //開始角度
    [SerializeField]
    private float   m_fAddAngle;        //加算角度
    [SerializeField]
    private bool    m_bIncreaseAngle;   //角度加算フラグ
    [SerializeField]
    private Vector2 m_Direction;        //方向

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        AngleUpdate();
        DirectionUpdate();
    }

    //初期化
    private void Init()
    {
        m_fAngle    = m_fStartAngle;
        m_Direction = Vector2.zero;
    }

    //角度の更新
    private void AngleUpdate()
    {
        if (m_bIncreaseAngle){
            m_fAngle += m_fAddAngle;
            if (m_fAngle >= m_fAngleMax){
                m_bIncreaseAngle = false;
            }
        }
        else{
            m_fAngle -= m_fAddAngle;
            if (m_fAngle <= m_fAngleMin){
                m_bIncreaseAngle = true;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, m_fAngle);
    }

    //方向の更新
    private void DirectionUpdate()
    {
        float fRad  = m_fAngle * Mathf.Deg2Rad;
        float fX    = Mathf.Cos(fRad);
        float fY    = Mathf.Sin(fRad);
        m_Direction = new Vector2(fX, fY);
    }

    //方向のゲッター
    public Vector2 Direction()
    {
        return m_Direction;
    }
}
