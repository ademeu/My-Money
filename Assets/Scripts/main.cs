using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    [SerializeField] GameObject _panel1, _text;
    [SerializeField] Text _text2;
    [SerializeField] Player1Controller _player1Controller;
    [SerializeField] Player2Control _player2Control;
    bool _panelacikMi = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    void Update()
    {
        if (Player1Controller.sayac1 + Player2Control._sayac2 == 9)
        {

            _panelacikMi = false;
            StartCoroutine(SureBeklet());
            Player1Controller.sayac1 = 0;
        }
        OyunSonu();
    }
    public void panelac()
    {
        _panel1.SetActive(true);

    }
    IEnumerator SureBeklet()
    {
        _panelacikMi = false;
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
    IEnumerator OyunaBasla()
    {
        _text2.text = "3";
        yield return new WaitForSeconds(1);
        _text2.text = "2";
        yield return new WaitForSeconds(1);
        _text2.text = "1";
        yield return new WaitForSeconds(1);
        
        SceneManager.LoadScene(1);
    }
    void OyunSonu()
    {
        if (Input.GetKey(KeyCode.Tab) && _panelacikMi)
        {

            _panel1.SetActive(true);
        }

        else if(_panelacikMi)
        {
            _panel1.SetActive(false);
        }
    }
    public void YenidenOyna()
    {
        
        StartCoroutine(OyunaBasla());
    }
}
