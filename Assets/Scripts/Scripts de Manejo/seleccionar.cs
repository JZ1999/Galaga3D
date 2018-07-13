using UnityEngine;
using UnityEngine.SceneManagement;

public class seleccionar : MonoBehaviour {

	#region Variables
	private int indice;
	private GameObject naveDeMuestra;
	private GameObject nave;
	private GameObject contenedorDeMuestra;
	private string[] naves;
	#endregion

	#region Unity Methods

	void Start() {
		naves = new string[] {"modelo0","modelo1"};
		indice = 0;

	}

	void Update() { 
    }

	public void Siguiente(GameObject contenedor)
	{
		
		if (indice < 1)
		{
			indice++;
			Destroy(GameObject.FindGameObjectWithTag(naves[indice-1]));
			Instantiate(contenedor.GetComponent<modelos>().naves[indice], contenedor.transform);
			nave = Informacion.navesObject[indice];
			
		}
	}

	public void Anterior(GameObject contenedor)
	{
		
		if (indice > 0)
		{
			indice--;
			Destroy(GameObject.FindGameObjectWithTag(naves[indice + 1]));
			Instantiate(contenedor.GetComponent<modelos>().naves[indice], contenedor.transform);
			nave = Informacion.navesObject[indice];
		}
	}

	public void Seleccion()
	{
		Informacion.J1 = indice;
		SceneManager.LoadScene(2);
	}

    #endregion
}
