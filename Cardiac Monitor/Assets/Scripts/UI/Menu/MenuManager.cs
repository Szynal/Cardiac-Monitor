using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// The class responsible for UI components (like buttons)
/// </summary>
public class MenuManager : MonoBehaviour
{

    /// <summary>
    /// Start the game
    /// </summary>
    public void StartGame()
    {
        Debug.Log("Start the game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /// <summary>
    /// Quit the game!
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }

}
