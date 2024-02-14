using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFCODE : MonoBehaviour
{
    public int apples;
    public int bananas;

        [ContextMenu("Exexcute If Test")]
        void ExecuteIfTest()
    {
        bool has4applesor2bananas = apples == 4 || bananas == 2;
        int moneyOwed = (apples == 4 && bananas == 2) ? 200 : -200; // if you want to be specific with #

        int moneyOwed2 = 0;
        //if either apples is 4 or bannas is 2
        if (has4applesor2bananas)
        {
            //Then print this message
            //{0} the place holder/dilemma for apple
            //{1} the place holder/dilemma for bananas
            //to indicate the values of the apple since we have more than one number
            Debug.Log(string.Format("We have {0} apples, and {1} bananas", apples, bananas));
        }


        //If both apples is 4 and bananas is 2

        if (apples == 4 && bananas == 2)
        {
            //Than print message
            moneyOwed2 = 200;
        }

        //If either apple or bananas is not 4/2 the if apples is 2 and bananas is less than
        //or equal to 10
        else if(apples == 2 && bananas <= 10)
        {
            moneyOwed2 = -200;
        }

        else if (apples == 2 || bananas <= 10)
        {
            //Than print message
            Debug.Log(string.Format("We have {0} apples, and {1} bananas", apples, bananas));
        }

        else
        {
            Debug.Log("we do not have 4 apples");
        }
    }
}
