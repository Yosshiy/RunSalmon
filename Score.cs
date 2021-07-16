using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スコア計算計
/// </summary>
public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    int ScoreCount = 0;

    /// <summary>
    /// Scoreを加算
    /// </summary>
    public void AddScore()
    {
        ScoreCount += 1;
    }

    /// <summary>
    /// Textに表示
    /// </summary>
    public void TextDisplay()
    {
        ScoreText.text = ScoreCount.ToString();
    }

    /// <summary>
    /// Scoreを返す
    /// </summary>
    public int GetScore()
    {
        return ScoreCount;
    }
}
