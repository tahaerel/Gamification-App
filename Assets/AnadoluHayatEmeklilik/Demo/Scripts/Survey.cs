using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Survey : MonoBehaviour
{

    [SerializeField] InputField feedback1;
    [SerializeField] Toggle toogle1;
    [SerializeField] Toggle toogle2;
    [SerializeField] Toggle toogle3;
    [SerializeField] Toggle toogle4;
    [SerializeField] Toggle toogle5;
    [SerializeField] Toggle toogle6;
    [SerializeField] Toggle toogle7;
    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdZSl7UNiOLEMTJSdeUxgIR9nu2sT3fmjb9rsdD7cjD5rXDIw/formResponse";

 string  a,b,c,d,e,f,g;
    void Update()
    {
        if (toogle1.isOn)
        {
             a = "Evet";
        }   
        if (toogle2.isOn)
        {
            b = "Hayır";
        }
        if (toogle3.isOn)
        {
            c = "1-3";
        }
        if (toogle4.isOn)
        {
            d = "3-6";
        }
        if (toogle5.isOn)
        {
            e = "6+";
        }
        if (toogle6.isOn)
        {
            f = "1-2";
        }
        if (toogle7.isOn)
        {
            g = "2+";
        }
    }

    public void Send()
    {
        StartCoroutine(Post(feedback1.text));
        StartCoroutine(Post2(a));
        StartCoroutine(Post2(b));
        StartCoroutine(Post3(c));
        StartCoroutine(Post3(d));
        StartCoroutine(Post3(e));
        StartCoroutine(Post4(f));
        StartCoroutine(Post4(g));
    }

    IEnumerator Post4(string s4)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.813273733", s4);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }
    IEnumerator Post3(string s3)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1574480235", s3);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }

    IEnumerator Post2(string s2)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.770347289", s2);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.690106655", s1);
        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();

    }


}