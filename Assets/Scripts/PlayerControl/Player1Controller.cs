using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Controller : MonoBehaviour
{
    [SerializeField] float _hiz;
    [SerializeField] Text _t1;
    public List<string> _list = new List<string>();
   
    void Update()
    {
        transform.position +=new Vector3 (Input.GetAxis("Horizontal") * Time.deltaTime * _hiz, Input.GetAxis("Vertical") * Time.deltaTime * _hiz,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "top":
                transform.localScale += new Vector3(0.024f, 0.024f);
                _list.Add("Carptin");

                Debug.Log(_list[0]);
                foreach (var item in _list)
                {
                    _t1.text = "" + _list.Count;
                }
                break;
        }
    }
}
