using UnityEngine;
using UnityEngine.SceneManagement;

public class seleccionar : MonoBehaviour {

	#region Variables
	//[SerializeField]
	private int indice;
	[SerializeField]
	private GameObject Manager;
	private GameObject nave;
	#endregion

	#region Unity Methods

	void Start() {
		indice = 0;
		//nave = Manager.GetComponent<>;
	}

	void Update() { 
    }

	public void Siguiente()
	{
		indice++;
		if (!(indice > 1))
			nave = Informacion.navesObject[indice];
	}

	public void Anterior()
	{
		indice--;
		if (!(indice < 0))
			nave = Informacion.navesObject[indice];
	}

	public void Seleccion()
	{
		Informacion.J1 = indice;
		if (Informacion.J1 != null)
			SceneManager.LoadScene("Nivel1");
		else
			Debug.LogAssertion("Error01: Nave seleccionada invalida");
	}

    #endregion
}
