using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlakkrManager : IMovements
{
    private string jump = "w";
    private string leftside = "a";
    private string rightside = "d";

    public string GetJumpKey
    {
        get { return jump; }
    }
    public string GetLeftKey
    {
        get { return leftside; }
    }
    public string GetRightKey
    {
        get { return rightside; }
    }
}
