using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhalyManagement : IMovements 
{
    private string jump = "up";
    private string leftside = "left";
    private string rightside = "right";

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
