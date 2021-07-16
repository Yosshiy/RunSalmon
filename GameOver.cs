using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// ゲームオーバー表示
/// </summary>
public class GameOver : MonoBehaviour
{
    [SerializeField] MapCreate _Map;
    //GameOver用のウィンドウ
    [SerializeField] GameObject Window;
    //距離のスコアText
    [SerializeField] Text Distance_Text;
    //獲得数のText
    [SerializeField] Text Score_Text;
    //総合得点のText
    [SerializeField] Text TotalScore_Text;
    //ScoreScriot
    [SerializeField] Score _Score;
    
    /// <summary>
    /// スコア反映
    /// </summary>
    public void Score_Display()
    {
        var score = _Score.GetScore();
        Score_Text.text = score.ToString();

        var distance = (int)Time.time;
        Distance_Text.text = distance.ToString();

        var total = score + distance;
        TotalScore_Text.text = total.ToString();
    }

    /// <summary>
    /// GameOver処理
    /// </summary>
    public void IsGameOver()
    {
        //Animation終了座標
        float endpos = 0;
        //何秒かけるか
        float duration = 2;
        Window.transform.DOLocalMoveY(endpos,duration);
        //マップの生成を辞める
        _Map.StopAllCoroutines();
    }
}
