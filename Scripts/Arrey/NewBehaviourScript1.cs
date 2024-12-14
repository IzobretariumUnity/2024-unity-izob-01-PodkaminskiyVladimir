using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    int[] name = new int[5] { 1, 2, 3, 4, 5 };

    private void Start()
    {
        // for

        for (int i = 0; i < name.Length; i++)
        {
            Debug.Log("Entry:" + name[i]);
        }

        //  int a = 3;
        // int b = 0;
        //int c = 0;

        // Debug.Log(" a * x * x + b * x + c = 0 ");

        //float d = (float) b * b - 4 * a * c;

        //if (d > 0)

        // int x1;
        // int x2;

        // else if(d)


    }
}


