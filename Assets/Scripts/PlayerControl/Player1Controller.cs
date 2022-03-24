
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "top":
                _list.Add("Carptin");
                foreach (var item in _list)
                {
                    _t1.text = "" + _list.Count;
                }
                sayac1 = _list.Count;
                break;
        }
    }

}
