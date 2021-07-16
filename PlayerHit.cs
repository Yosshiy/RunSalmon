using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerの当たり判定
/// </summary>
public class PlayerHit : MonoBehaviour
{
    //Score計算用
    [SerializeField] Score _Score;
    //GameOver用
    [SerializeField] GameOver _GameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy_Point"))
        {
            Destroy(collision.gameObject);
            _Score.AddScore();
            _Score.TextDisplay();
            
        }
        else if (collision.CompareTag("Enemy"))
        {
            _GameOver.Score_Display();
            _GameOver.IsGameOver();
        }
    }
}
