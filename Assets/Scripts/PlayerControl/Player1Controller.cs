using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour
{
    [SerializeField] float _hiz;
    [SerializeField] Text _t1;
    [SerializeField] SpriteRenderer _player1Sprite;
    public static int sayac1;
    public List<string> _list = new List<string>();
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position +=new Vector3 (Input.GetAxis("Horizontal") * Time.deltaTime * _hiz, Input.GetAxis("Vertical") * Time.deltaTime * _hiz,0);
        if (Input.GetAxis("Horizontal") > 0)
        {
            _player1Sprite.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            _player1Sprite.flipX = true;
        }
        //if (Input.GetAxis("Vertical") > 0)
        //{
        //    _player1Sprite.flipY = false;
        //}
        //if (Input.GetAxis("Vertical") < 0)
        //{
        //    _player1Sprite.flipY = true;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "top":
                _list.Add("Carptin");
                transform.localScale += new Vector3(0.018f, 0.018f);
                foreach (var item in _list)
                {
                    _t1.text = "" + _list.Count;
                }
                sayac1 = _list.Count;
                break;
        }
    }

}
