using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class counter : MonoBehaviour
{
    public TMP_Text textObject;
    int hp = 100;
    private void OnCollisionEnter(Collision collider)
    {
        hp--;
        textObject.text = "HP = " + hp.ToString();
    }
}
