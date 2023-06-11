using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using Rnd = UnityEngine.Random;

public static class Helper {

	public static List<char> AppendPlayfairAlphabet(List<char> keySection)
    {
        string alpha = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        List<char> keyGrid = keySection;
        for (int i = 0; i < 25; i++)
        {
            if (!keyGrid.Contains(alpha[i]))
                keyGrid.Add(alpha[i]);
        }

        return keyGrid;
    }

    public static void PrintListAsMatrix(List<char> list)
    {
        for (int row = 0; row < 5; row++)
        {
            string line = "";
            for (int col = 0; col < 5; col++)
            {
                line += list[row * 5 + col];
            }
            Debug.Log(line);
        }
    }
}
