using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Bracket : MonoBehaviour
{
    public string bracket;
    public List<int> _bracket;
    void Start() {

        SpilString(bracket);

    }

    public void SpilString(string st) {
        int Unbalance = 0;
        int a = 0;
        int b = 0;
        var res = st.Select(x => new string(x, 1)).ToArray();
        var q = from x in res
                group x by x into g
                let count = g.Count()
                orderby count descending
                select new { Value = g.Key, Count = count };
        foreach (var x in q) {
            Debug.Log("Value: " + x.Value + " Count: " + x.Count);
            _bracket.Add(x.Count);
        }
        if (_bracket[0] == _bracket[1]) {
            if (res[0] == "(") {
                for (int i = 1; i < res.Length; i++) {
                    if (b == 0) {
                        if (res[i] == "(") {
                            a++;
                        } else {
                            b = 1;
                        }
                    } else {
                        if (res[i] == ")") {
                            b++;
                        }
                        if (a == b) {
                            b = 0;
                            a = 0;
                            Unbalance = 0;
                        } else {
                            a--;

                        }
                    }
                }
                if (Unbalance == 0) {
                    Debug.Log("balance");
                } else {
                    Debug.Log("Unbalance");
                }
            } else { Debug.Log("Unbalance"); }
        } else {
            Debug.Log("Unbalance");
        }
    }
}
