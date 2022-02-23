using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Control : MonoBehaviour
{
  
   [SerializeField] float _yatay,_dikey;
    [SerializeField] Text _t2;
    Rigidbody2D _rg;
    bool _up, _down, _right, _left;
    string[] dizi = new string[15];
    public int _dizi1=0;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Keypad8))
        {
            _up = true;

        }
        else
        {
            _up = false;
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            _down = true;

        }
        else
        {
            _down = false;
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            _left = true;

        }
        else
        {
            _left = false;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            _right = true;

        }
        else
        {
            _right = false;
        }
    }
    private void FixedUpdate()
    {
        if (_up)
        {
            transform.position += new Vector3(0, _dikey);
        }
        if (_down)
        {
            transform.position -= new Vector3(0, _dikey);
        }
        if (_right)
        {
            transform.position += new Vector3(_yatay, 0f);
        }
        if (_left)
        {
            transform.position -= new Vector3(_yatay, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "top":
                transform.localScale += new Vector3(0.024f, 0.024f);
                dizi[_dizi1] = "Carptin";
                _dizi1 += 1;
                _t2.text = "" + _dizi1;

                break;
        }
    }
    
}
