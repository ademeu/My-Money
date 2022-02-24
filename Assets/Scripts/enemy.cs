using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] Rigidbody2D rg;
    [SerializeField] SpriteRenderer _enemy1Sprite, _enemy2Sprite, _enemy3Sprite;
    bool _zipla;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "player1":
              
                Destroy(this.gameObject);

                break;
            case "player2":
            
                Destroy(this.gameObject);

                break;
        }
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _zipla = true;
        }
        else
        {
            _zipla = false;
        }
    }
    private void FixedUpdate()
    {
        if (_zipla)
        {
            rg.AddForce(new Vector2(0.1f, -2f));
            _enemy1Sprite.color = Random.ColorHSV();
            _enemy2Sprite.color = Random.ColorHSV();
            _enemy3Sprite.color = Random.ColorHSV();
        }
    }

}
