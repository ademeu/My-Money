using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
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
}
