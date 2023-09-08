// Play Button - 
// Name: Chloe Park 
// Aimed Completion Date: October 17, 2023
// Purpose: Trigger for Play Button 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Play Function - 
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Switches to Play Scene
    }
}
