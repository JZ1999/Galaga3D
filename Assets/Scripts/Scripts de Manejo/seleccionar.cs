using UnityEngine;
using UnityEngine.SceneManagement;

public class seleccionar : MonoBehaviour {

	#region Variables
	private int _indice;//Controla cual nave está seleccionada
	private GameObject naveDeMuestra;
	private GameObject nave;
	private GameObject contenedorDeMuestra;
	private string[] _naves;//Contiene todas las naves disponibles del juego
	#endregion

	#region Unity Methods

	void Start() {
		_naves = new string[] {"modelo0","modelo1"};
		_indice = 0;

	}

	void Update() { 
    }

	public void Siguiente(GameObject contenedor)
	{
		
		if (_indice < 1)
		{
			_indice++;
			Destroy(GameObject.FindGameObjectWithTag(_naves[_indice - 1]));
			Instantiate(contenedor.GetComponent<modelos>().naves[_indice], contenedor.transform);
			nave = Informacion.navesObject[_indice];
			
		}
	}

	public void Anterior(GameObject contenedor)
	{
		
		if (_indice > 0)
		{
			_indice--;
			Destroy(GameObject.FindGameObjectWithTag(_naves[_indice + 1]));
			Instantiate(contenedor.GetComponent<modelos>().naves[_indice], contenedor.transform);
			nave = Informacion.navesObject[_indice];
		}
	}

	public void Seleccion()
	{
		Informacion.J1 = _indice;
		SceneManager.LoadScene(2);
	}

    #endregion
}
