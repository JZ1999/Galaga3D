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
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		Debug.Log("EXIT");
		Application.Quit();
	}

	public void Naves()
	{

	}

	public void Opciones()
	{

	}
}
