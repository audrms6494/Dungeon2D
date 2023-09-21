using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] List<GameObject> inputObjectList;

    public void UIOnOff()
    {
        foreach (GameObject inputObject in inputObjectList)
        {
            if (inputObject.activeSelf)
                inputObject.SetActive(false);
            else
                inputObject.SetActive(true);
        }
    }
}
