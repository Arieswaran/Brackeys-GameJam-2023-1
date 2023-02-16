using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCounter : MonoBehaviour
{
    int redCheese;
    int greenCheese;
    int blueCheese;

    private void Start()
    {
        Cheese.OnAnyCheeseConsumed += Cheese_OnAnyCheeseConsumed;
    }

    private void Cheese_OnAnyCheeseConsumed(object sender, System.EventArgs e)
    {
        Cheese cheese = sender as Cheese;

        switch (cheese.cheeseType)
        {
            case Cheese.CheeseType.Red:
                MazePhaseManager.Instance.IncreaseRedCheeseCount();
                redCheese++;
                break;
            case Cheese.CheeseType.Green:
                MazePhaseManager.Instance.IncreaseGreenCheeseCount();
                greenCheese++;
                break;
            case Cheese.CheeseType.Blue:
                MazePhaseManager.Instance.IncreaseBlueCheeseCount();
                blueCheese++;
                break;
        }

        Debug.Log($"Red: {redCheese} Green: {greenCheese} Blue: {blueCheese}");
    }
}
