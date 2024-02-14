using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanoiTower : MonoBehaviour
{
    int[] peg1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
    int[] peg2 = { 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] peg3 = { 0, 0, 0, 0, 0, 0, 0, 0 };

    int currentPeg = 1;

    [ContextMenu("MoveRight")]

    void MoveRight()
    {
        //Get lists we are working with
        int[] currentList = GetPeg(currentPeg);
        int[] targetList = GetPeg(currentPeg + 1);

        //Check target list a real list
        if (targetList == null) return;

        //Get top # index from current list

        int fromIndex = GetTopNumberIndex(currentList);
        // Get bottom # index from current list
        int toIndex = GetBottomNumberIndex(targetList);

        //Check # we want doesn't brake rules
        //for moving between pegs(no big # on top of small#)
        if (toIndex == -1) return;

        if (CanMoveIntoPeg(currentList[fromIndex], currentList) == false) return;
    }

    void MoveLeft()
    {
        //Get lists we are working with
        int[] currentList = GetPeg(currentPeg);
        int[] targetList = GetPeg(currentPeg + 1);

        //Check target list a real list
        if (targetList == null) return;

        //Get top # index from current list

        int fromIndex = GetTopNumberIndex(currentList);
        // Get bottom # index from current list
        int toIndex = GetBottomNumberIndex(targetList);

        //Check # we want doesn't brake rules
        //for moving between pegs(no big # on top of small#)
        if (toIndex == 1) return;

        if (CanMoveIntoPeg(currentList[fromIndex], currentList) == false) return;
    }

    int GetTopNumberIndex(int[] peg)
    {
        for(int i=0; i<peg.Length; i++)
        {
            if (peg[i] != 0) return i;
            //if the value for the index in the peg is not a 0.
        }

        return -1;
    }

    int GetBottomNumberIndex(int[] peg)
    {
        for (int i = peg.Length -1; i >= 0; i--)
        {
            //if the value for the index in the peg is not a 0.
            if (peg[i] == 0) return i;
        }

        return -1;
    }

    bool CanMoveIntoPeg(int numberToMove, int[] peg)
    {
        int bottomIndex = GetBottomNumberIndex(peg);

        if (bottomIndex == peg.Length - 1 && peg[peg.Length - 1] == 0) return true;

        int bottomPlus1 = bottomIndex + 1;
        return bottomPlus1 == 0; //This makes it true or false. 
       
    }

    void MoveIntoPeg (int fromIndex, int toIndex, int[] from, int[] to)
    {
        int NumberToMove = from[fromIndex];
        from[fromIndex] = 0;
    }

    int[] GetPeg(int peg)
    {
        //the return prevents execution that's why we don't need "else" before the if. 
        if (peg == 1) return peg1; 
        if (peg == 2) return peg2;
        if (peg == 3) return peg3;

        return null;
    }
}
