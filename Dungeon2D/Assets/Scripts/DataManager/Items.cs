using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject isEquipped_Axe;
    public GameObject isEquipped_Armor;
    public GameObject isEquipped_Hammer;
    public GameObject isEquipped_Book;

    public void AxeControl()
    {
        if (!PlayerPrefs.HasKey("Axe") || PlayerPrefs.GetInt("Axe") == 0)
        {
            EquipAxe();
        }
        else if (PlayerPrefs.GetInt("Axe") == 1)
        {
            UnequipAxe();
        }
    }

    public void ArmorControl()
    {
        if (!PlayerPrefs.HasKey("Armor") || PlayerPrefs.GetInt("Armor") == 0)
        {
            EquipArmor();
        }
        else if (PlayerPrefs.GetInt("Armor") == 1)
        {
            UnequipArmor();
        }
    }

    public void HammerControl()
    {
        if (!PlayerPrefs.HasKey("Hammer") || PlayerPrefs.GetInt("Hammer") == 0)
        {
            EquipHammer();
        }
        else if (PlayerPrefs.GetInt("Hammer") == 1)
        {
            UnequipHammer();
        }
    }

    public void BookControl()
    {
        if (!PlayerPrefs.HasKey("Book") || PlayerPrefs.GetInt("Book") == 0)
        {
            EquipBook();
        }
        else if (PlayerPrefs.GetInt("Book") == 1)
        {
            UnequipBook();
        }
    }


    public void EquipAxe()
    {
        PlayerPrefs.SetInt("ATK", PlayerPrefs.GetInt("ATK") + 6);
        PlayerPrefs.SetInt("Axe", 1);
        isEquipped_Axe.SetActive(true);
    }

    public void UnequipAxe()
    {
        PlayerPrefs.SetInt("ATK", PlayerPrefs.GetInt("ATK") - 6);
        PlayerPrefs.SetInt("Axe", 0);
        isEquipped_Axe.SetActive(false);
    }

    public void EquipArmor()
    {
        PlayerPrefs.SetInt("DEF", PlayerPrefs.GetInt("DEF") + 5);
        PlayerPrefs.SetInt("Armor", 1);
        isEquipped_Armor.SetActive(true);
    }

    public void UnequipArmor()
    {
        PlayerPrefs.SetInt("DEF", PlayerPrefs.GetInt("DEF") - 5);
        PlayerPrefs.SetInt("Armor", 0);
        isEquipped_Armor.SetActive(false);
    }

    public void EquipHammer()
    {
        PlayerPrefs.SetInt("CRT", PlayerPrefs.GetInt("CRT") + 10);
        PlayerPrefs.SetInt("Hammer", 1);
        isEquipped_Hammer.SetActive(true);
    }

    public void UnequipHammer()
    {
        PlayerPrefs.SetInt("CRT", PlayerPrefs.GetInt("CRT") - 10);
        PlayerPrefs.SetInt("Hammer", 0);
        isEquipped_Hammer.SetActive(false);
    }

    public void EquipBook()
    {
        PlayerPrefs.SetInt("HP", PlayerPrefs.GetInt("HP") + 15);
        PlayerPrefs.SetInt("Book", 1);
        isEquipped_Book.SetActive(true);
    }

    public void UnequipBook()
    {
        PlayerPrefs.SetInt("HP", PlayerPrefs.GetInt("HP") - 15);
        PlayerPrefs.SetInt("Book", 0);
        isEquipped_Book.SetActive(false);
    }

}
