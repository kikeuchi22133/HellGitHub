using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShot : MonoBehaviour
{
    //ショットトリガー
    public bool ShotTrigger(string KEYNAME)
    {
        bool bTrigger = Input.GetKeyDown(KEYNAME);
        return bTrigger;
    }

    //ショット
    public void Shot(GameObject BALLOBJECT, GameObject PLAYEROBJECT)
    {
        Instantiate(BALLOBJECT, PLAYEROBJECT.transform.localPosition, Quaternion.identity);
    }

}
