using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Changecolor : MonoBehaviour
{

    public GameObject renkdegis;
    public GameObject renkdegis2;
    public GameObject renkdegis3;
    public GameObject renkdegis4;

    public GameObject darkbutton;
    public GameObject whitebutton;

    public void dark() {
    darkbutton.SetActive(false);
    whitebutton.SetActive(true);

    renkdegis.GetComponent<Image>().color = new Color32(44, 37, 37, 255);
    renkdegis2.GetComponent<Image>().color = new Color32(44, 37, 37, 255);
    renkdegis3.GetComponent<Image>().color = new Color32(44, 37, 37, 255);
    renkdegis4.GetComponent<Image>().color = new Color32(44, 37, 37, 255);
    }
    public void white()
    {
        whitebutton.SetActive(false);
        darkbutton.SetActive(true);
        

        renkdegis.GetComponent<Image>().color = new Color32(221, 221, 221, 255);
        renkdegis2.GetComponent<Image>().color = new Color32(221, 221, 221, 255);
        renkdegis3.GetComponent<Image>().color = new Color32(221, 221, 221, 255);
        renkdegis4.GetComponent<Image>().color = new Color32(221, 221, 221, 255);

    }

}
