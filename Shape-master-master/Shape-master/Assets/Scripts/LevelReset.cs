using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelReset : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }



}
