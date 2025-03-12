using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void StartNewGame()
    {
        GameManager.Instance.LoadLevel2();
        GameManager.Instance.InitializeGame();
    }
}
