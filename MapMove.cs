using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// マップが動く
/// </summary>
public class MapMove : MonoBehaviour
{
    //動くスピード
    int Duration = 8;

    private void Start()
    {
        var endpos = transform.position.x;
        transform.DOMoveX(-endpos,Duration).SetEase(Ease.Linear).OnComplete(()=>Destroy(this.gameObject));
    }
}
