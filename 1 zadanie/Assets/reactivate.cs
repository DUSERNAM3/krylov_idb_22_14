using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactivate : MonoBehaviour
{
    public GameObject obj;
    int cnt = 0;
    public void deactivate()
    {
        if (cnt == 0)
        {
            obj.SetActive(false);
            cnt++;
        }
        else
        {
            obj.SetActive(true);
            cnt--;
        }
    }
}
