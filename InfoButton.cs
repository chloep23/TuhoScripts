// Info Button - 
// Name: Chloe Park 
// Aimed Completion Date: October 17, 2023
// Purpose: Trigger for Info Button 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    // Info Function - 
    public void InfoGame()
    {
        SceneManager.LoadScene(0); // Switches to Main Menu Scene
    }
}
