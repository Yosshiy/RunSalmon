using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マップ自動生成
/// </summary>
public class MapCreate : MonoBehaviour
{
    //生成位置
    [SerializeField]Transform CreatePosition;
    //マップのパターン
    [SerializeField]List<GameObject> Paturn;
    //ボーナスマップのパターン
    [SerializeField]List<GameObject> BounusPaturn;
    //何秒おきに生成するか
    [SerializeField]int interval;

    private void Start()
    {
        StartCoroutine(MapView());
    }

    /// <summary>
    /// 生成Coroutine
    /// </summary>
    IEnumerator MapView()
    {
        while (true)
        {
            Instantiate(Paturn[Random.Range(0, Paturn.Count)],CreatePosition.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }

}
