using UnityEngine;
using UnityEngine.SceneManagement;
[DisallowMultipleComponent]
public class main_menu : MonoBehaviour {

    #region Variables

    #endregion

    #region Unity Methods

    #endregion

	public void Jugar()
	{
		SceneManager.LoadScene(1);
	}

	public void Salirse()
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
