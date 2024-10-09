using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type int
    int myInt = 11;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        //I want to know what my y location is at all times
        Debug.Log(transform.position.y);
    }



    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}