using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CFlagManager
{
    public static bool m_bGameStart = false;
    public static bool m_bGameStop  = true;

    public static bool GameStart()
    {
        if (!m_bGameStart){
            if (Input.GetKeyDown(KeyCode.Space)){
                m_bGameStart    = true;
            }
        }
        else{
            if (Input.GetKeyDown(KeyCode.Space)){
                m_bGameStart = false;
            }
        }
        return m_bGameStart;
    }

    public static bool GameStop()
    {
        if (m_bGameStart){
            if (Input.GetKeyDown(KeyCode.Space)){
                m_bGameStart    = false;
                m_bGameStop     = true;
            }
        }
        return m_bGameStop;
    }
}
