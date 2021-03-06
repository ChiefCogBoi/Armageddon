﻿// -----------------------------------------------------------------------------
#region File Info - EnableObjectAction.cs
// -----------------------------------------------------------------------------
// Project:     Dino Unity Toolkit
// Created:     Sarah Herzog 2019
// Purpose:     Enables or disables a GameObject
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Libraries
// -----------------------------------------------------------------------------
using UnityEngine;
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Component: EnableObjectAction
// -----------------------------------------------------------------------------
[HelpURL("https://github.com/CodingDino/FifeCollege-Unity-DragNDrop/wiki/EnableObjectAction")]
public class EnableObjectAction : MonoBehaviour
{

    // -------------------------------------------------------------------------
    #region Action Functions
    // -------------------------------------------------------------------------
    public void ActionEnableObject(GameObject toEnable)
    {
        // Set the game object to active (enabled)
        toEnable.SetActive(true);
    }
    // -------------------------------------------------------------------------
    public void ActionDisableObject(GameObject toDisable)
    {
        // Set the game object to inactive (disabled)
        toDisable.SetActive(false);
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


}
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------