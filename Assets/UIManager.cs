using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadGameChoiceMenu()
    {
        SceneManager.LoadScene("Games Choice"); // Replace "GameChoice" with your scene's exact name
    }
}
