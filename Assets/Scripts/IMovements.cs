using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovements
{ 
    string GetJumpKey { get; }
    string GetLeftKey { get; }
    string GetRightKey { get; }
}
