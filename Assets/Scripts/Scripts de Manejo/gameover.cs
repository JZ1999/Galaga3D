using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class gameover : MonoBehaviour {

	#region Variables
	public GameObject menuUI;
	#endregion

	#region Metodos de Unity


	private void Update()
	{
		if (Informacion.muerto)
		{
			menuUI.active = true;
			Time.timeScale = 0.1f;
		}
	}

	#endregion

	public void reiniciar()
	{
		menuUI.active = false;
		Time.timeScale = 1f;
		Informacion.muerto = false;
		Camara3D.tiempo = 5f;//Darle n segundos de espera para que todo cargue
		SceneManager.LoadScene(2);
	}

	public void salir()
	{
		menuUI.active = false;
		Time.timeScale = 1f;
		Informacion.muerto = false;
		SceneManager.LoadScene(0);
	}

	public void seleccionDeNaves()
	{
		menuUI.active = false;
		Time.timeScale = 1f;
		Informacion.muerto = false;
		Camara3D.tiempo = 5f;//Darle n segundos de espera para que todo cargue
		SceneManager.LoadScene(1);
	}
}
