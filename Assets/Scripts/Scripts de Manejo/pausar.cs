using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class pausar : MonoBehaviour {

	#region Variables
	public static bool _juegoEnPausa = false;
	public GameObject menuUI;
    #endregion

    #region Metodos de Unity
    
    void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (_juegoEnPausa)
				continuar();
			else
				pausa();

		}
    }
	#endregion

	public void continuar()
	{
		menuUI.active = false;
		Time.timeScale = 1f;
		_juegoEnPausa = false;
	}

	public void pausa()
	{
		menuUI.active = true;
		Time.timeScale = 0f;
		_juegoEnPausa = true;
	}

	public void salir()
	{
		menuUI.active = false;
		Time.timeScale = 1f;
		_juegoEnPausa = false;
		SceneManager.LoadScene(0);
	}
}
