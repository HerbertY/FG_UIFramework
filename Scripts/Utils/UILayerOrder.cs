using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// UI层级排序       by:heyang 2018/6/11
/// </summary>
public class UILayerOrder : MonoBehaviour {
    [SerializeField, SetProperty("Order")]
    private int order = 0;
    public int Order
    {
        get
        {
            return order;
        }
        set
        {
            order = value;
            SetLayerOrder();
        }
    }

    /// <summary>
    /// 设置层级
    /// </summary>
    private void SetLayerOrder()
    {
        Canvas canvas = GetComponent<Canvas>();
        if (canvas == null)
        {
            canvas = gameObject.AddComponent<Canvas>();
        }

        canvas.overrideSorting = true;
        canvas.sortingOrder = order;
    }
}
