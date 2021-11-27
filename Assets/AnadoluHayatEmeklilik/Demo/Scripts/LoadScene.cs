using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public int sahneid;
    public int sahneid2;
    public void sahnegec()
    {
        SceneManager.LoadScene(sahneid);

    }
    public void sahnegec2()
    { 
        SceneManager.LoadScene(sahneid2);
    }
}
