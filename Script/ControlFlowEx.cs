using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity.VisualScripting;

public class ControlFlowEx
{
    // Executes one block of code if a condition is true, and another block if the condition is false.
    void IfelseStatement() {
        int number = 10;
        if (number > 10)
        {
            Console.WriteLine("Number is greater than 10");
        }
        else if (number == 10)
        {
            Console.WriteLine("Number is 10");
        }
        else {
            Console.WriteLine("Number is less than 10");
        }
    }

    // Checks multiple conditions.
    void SwitchStatement() {
        int day = 3;
        switch (day)
        {   
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Other day");
                break;
        }
    }

    void LoopStatement() {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }
    }

    void ForEachLoopStatement() {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Number = " + number);
        }
    }

    void WhileLoopStatement() {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("i = " + i);
            i++;
        }
    }

    void DoWhileLoopStatement() {
        int i = 0;
        do
        {
            Console.WriteLine("i = " + i);
            i++;
        } while (i < 5);
    }

    void JumpStatement() {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine("i = " + i);
        }
    }

    void ContinueStatement() {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine("i = " + i);
        }
    }

    void ReturnStatement() {
        int Add(int a, int b)
        {
            return a + b;
        }

        int result = Add(3, 4);
        Console.WriteLine("Result = " + result);
    }

    void GotoStatement() {
        int i = 0;
        start:
        Console.WriteLine("i = " + i);
        i++;
        if (i < 5)
        {
            goto start;
        }
    }

}
