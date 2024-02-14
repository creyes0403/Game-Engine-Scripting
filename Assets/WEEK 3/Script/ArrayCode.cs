using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCode : MonoBehaviour
{ //Array = To create a list

    [SerializeField]
    int[][] scoresArr = new int[4][];//The # is how many items it can contain

    int[,] scoresArr2 = new int[3,3]; //2D 

    [ContextMenu("Exexcute If Test")]

    void execute()
    {
        scoresArr[0] = new int[4] { 1, 2, 3, 4 };
        scoresArr[0] = new int[4] { 5, 6, 7, 8 };
        scoresArr[0] = new int[4] { 9, 10, 11, 12 };
        scoresArr[0] = new int[4] { 13, 14, 15, 16 };

        /*for (int i=0; i < scoresArr.Length; i++)
        {
            Debug.LogFormat("The number is...{0} tadums!", scoresArr[i]);
        }*/

        //for each nested array in our array(s)
        //length tells you the #rows you have

        for (int i = 0; i < scoresArr.Length; i++)
        {
            for (int j = 0; j < scoresArr.Length; j++)
            {
                Debug.LogFormat("The number is...{0} tadums!", scoresArr[i][j]);
            }
        }

        int numberOfRows = scoresArr2.GetLength(0);
        int numberOfCols = scoresArr2.GetLength(1);

        for (int i=0; i <numberOfRows; i++)
        {
            for (int j = 0; j < numberOfCols; j++)
            {
                Debug.LogFormat("The number is...{0} tadums!", scoresArr2[i,j]);
            }
        }
    }
}
