using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Array : MonoBehaviour
{
    public List<int> values;
    public int[] sameInt;
    void Start() {
        var q = from x in values
                group x by x into g
                let count = g.Count()
                orderby count descending
                select new { Value = g.Key, Count = count };
        foreach (var x in q) {
            if (x.Count>1) {
                Debug.Log("Value: " + x.Value + " Count: " + x.Count);
            }
        }
    }

}
