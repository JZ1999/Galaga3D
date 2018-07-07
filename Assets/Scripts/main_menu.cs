using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

    #region Variables

    #endregion

    #region Unity Methods

    void Start () {
        
    }
    
    void Update () {
        
    }

    #endregion

	public void PlayGame()
	{
		SceneManager.LoadScene("Selection");
	}

	public void QuitGame()
	{
		Debug.Log("EXIT");
		Application.Quit();
	}
}
