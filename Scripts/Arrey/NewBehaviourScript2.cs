using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    private int[] ihs = new int[10] { 3, 4, 7, 8, 2, 5, 3, 7, 8, 2 };

    private void Start()
    {
        float sum = 0;
        for (int i = 0; i < ihs.Length; i++)
        {
            sum = sum + ihs[i];
        }

        int r = ihs.Length;
        Debug.Log(sum / r);
    }

}
