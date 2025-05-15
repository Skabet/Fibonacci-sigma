using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Fibonacci : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sumUntilLimit(0, 0, 1, 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sumUntilLimit(float sum, float n1,float n2,  float limit)
    {
        Debug.Log(n1);
        sum = (n1) + (n2);

        if (sum < limit) 
        {
            sumUntilLimit(sum, n1 = n2, n2 = sum, limit);
        }
    }
}
