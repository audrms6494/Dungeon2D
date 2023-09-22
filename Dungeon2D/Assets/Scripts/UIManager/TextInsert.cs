using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextInsert : MonoBehaviour
{
    public TMP_Text tmp;

    private void Start()
    {
        ShowName();
    }

    public void ShowName()
    {
        tmp.text = PlayerPrefs.GetString("PlayerName");
    }
}
