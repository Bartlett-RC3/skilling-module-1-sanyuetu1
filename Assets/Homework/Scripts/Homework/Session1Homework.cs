﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    public int myInteger = 10;
    public int maxInteger = int.MaxValue;
    public double myDouble = 12.34;
    public double minDouble = double.MinValue;
    public float myFloat = 12.34f;
    public decimal myDecimal = 1.324m;
    public string myString = "This is my homework!";
    public bool myBoolean = !true;

    public int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
    public float[] myTenElementsFloatArray = new float[10];
    public int[,] myTwoDimentioalArray = new int[3, 5];
    public List<float> myList = new List<float>(){1.1f,2.2f,3f,4.5f,5f,6f,3f,8f};
    

    Dictionary<string, string> Games = new Dictionary<string, string>();

    // Use this for initialization
    public void Start ()
    {
        myList[0] = 1;
        myIntArray[2] = 300;
        Debug.Log(myIntArray[1].ToString());
        myList.Add(1234);
        myList.Add(2);
        myList.Add(3);
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count - 1].ToString());


        Games.Add("RPG", "JW3");
        Games.Add("RPG", "Final Fantasy");
        Games.Add("MOBA", "Dota2");
        Games.Add("MOBA", "LOL");
        Games.Add("FPS", "Call of Duty");
        Games.Add("FPS", "PUBG");
        if (Games.ContainsKey("FPS"))
        {
            Debug.Log(Games.Values+ " : it is an FPS game! ");
        }
    }

    public float NumberAddition(float a, float b)
    {
        return a + b;
    }

    public void PrintSomeNumbers()
    {
        Debug.Log(myList[0]);
        Debug.Log(myIntArray[0]);
        Debug.Log(myInteger);
    }

    public int AddtionOfNumbers(int number1, int number2)
    {
        int addtionResult = number1 + number2;
        return addtionResult;
    }
    // Update is called once per frame
    void Update ()
	{
		
	}
}
