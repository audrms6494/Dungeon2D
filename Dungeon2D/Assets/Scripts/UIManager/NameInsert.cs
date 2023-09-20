using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInsert : MonoBehaviour
{
    public TMP_InputField inputName;
    public void SaveName()
    {
        PlayerPrefs.SetString("PlayerName", inputName.text);
    }
}
