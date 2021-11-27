using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SliderScene : MonoBehaviour
{
    public GameObject slider;
    public GameObject slider2;

    public void slidergec()
    {
        slider.SetActive(false);
        slider2.SetActive(true);

    }
    public void sahnegec()
    {
        SceneManager.LoadScene(1);
    }


}
