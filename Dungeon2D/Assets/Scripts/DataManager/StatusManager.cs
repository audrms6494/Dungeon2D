using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public TMP_Text ATK_value;
    public TMP_Text DEF_value;
    public TMP_Text HP_value;
    public TMP_Text CRT_value;
    void Start()
    {
        PlayerPrefs.SetInt("ATK", 8);
        PlayerPrefs.SetInt("DEF", 6);
        PlayerPrefs.SetInt("HP", 12);
        PlayerPrefs.SetInt("CRT", 0);
    }

    public void InsertData()
    {
        ATK_value.text = PlayerPrefs.GetInt("ATK").ToString();
        DEF_value.text = PlayerPrefs.GetInt("DEF").ToString();
        HP_value.text = PlayerPrefs.GetInt("HP").ToString();
        CRT_value.text = PlayerPrefs.GetInt("CRT").ToString();
    }
}
