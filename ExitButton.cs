// Exit Button - 
// Name: Chloe Park 
// Aimed Completion Date: Monday, October 17
// Purpose: Trigger for Exit Button 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Exit Function - 
    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Only in Unity Editor
        #endif
            Application.Quit(); // On Separate Application 
    }
}
