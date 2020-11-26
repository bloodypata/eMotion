using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoldButton : MonoBehaviour
{
    public GameObject[] laundry;
    public InventoryForLaundry script;
    public GameObject[] MyButton;
    public GameObject ObjectToHaveNewNav;



    void Update()
    {
        Navigation NewNav = new Navigation();
        NewNav.mode = Navigation.Mode.Explicit;
        
        
        if (laundry[0].activeSelf ==true)
        {
            NewNav.selectOnRight = MyButton[0].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[1].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[1].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;

        }
        if (laundry[2].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[2].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[3].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[3].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[4].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[4].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;

        }
        if (laundry[5].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[5].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[6].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[6].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[7].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[7].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[8].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[8].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }
        if (laundry[9].activeSelf == true)
        {
            NewNav.selectOnRight = MyButton[9].GetComponent<Button>();
            ObjectToHaveNewNav.GetComponent<Button>().navigation = NewNav;
        }

    }
    public void DeleteFromList()
    {
        for (var i = 0; i < script.basket.Count; i++)
        {
                script.basket[i].SetActive(true);
                script.basket.Remove(script.basket[i]);
                break;
              
        }
    }
}
