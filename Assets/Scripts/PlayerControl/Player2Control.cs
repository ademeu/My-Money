using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Control : MonoBehaviour
{
    [SerializeField] float _yatay,_dikey;
    [SerializeField] SpriteRenderer _player2Sprite;
    [SerializeField] Text _t2;
    Rigidbody2D _rg;
    bool _up, _down, _right, _left;
    string[] dizi = new string[15];
    public int _dizi1=0;
    public static int _sayac2;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
           _down= false;
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            _left = true;
            _player2Sprite.flipX = false;

        }
        else
        {
            _left = false;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            _right= true;
            _player2Sprite.flipX = true;

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
            transform.position += new Vector3(0,_dikey);
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
                _sayac2 = _dizi1;
                break;
        }
    }
    
}
