using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    [SerializeField] GameObject _panel1,_text;
    [SerializeField] Text _text2;

    void Update()
    {

        if (Input.GetKey(KeyCode.Tab))
        {
            _panel1.SetActive(true);
        }
        else
        {
            _panel1.SetActive(false);
        }
    }
    public void panelac()
    {
        _panel1.SetActive(true);
    }
    IEnumerator SureBeklet()
    {
        _text.SetActive(true);
        _text2.text = "3";
        yield return new WaitForSeconds(1);
        _text2.text = "2";
        yield return new WaitForSeconds(1);
        _text2.text = "1";
        yield return new WaitForSeconds(1);
        
        _text.SetActive(false); 
        panelac();

    }
    public void button11()
    {
        StartCoroutine(SureBeklet());

    }
}
