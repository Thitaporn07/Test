using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    public int x;
    string t;
    public List<string> tree;
    // Start is called before the first frame update
    void Start()
    {
        CreateTree(x);
    }
    public void CreateTree(int x) {
        
        for (int i = 0; i <= x; i++) {
            if (i%2!=0) {
               // Debug.Log(i);
                for (int j = 0; j < i; j++) {
                    // Debug.Log("*");
                    t += "*";
                }
                tree.Add(t);
                t = "";
            }
        }
        foreach (var item in tree) {
            Debug.Log(item);
        }
    }
}
