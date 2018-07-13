using UnityEngine;

public class Camara3D : MonoBehaviour {

	#region Variables
	
	private Transform jugador;
	[SerializeField]
	private float velocidadCamara = 0.25f;
	[SerializeField]
	private Vector3 offset;
	#endregion

	#region Unity Methods

	void Start () {
		jugador = GameObject.FindGameObjectWithTag("Player").transform;
		//transform.position = camara2D.transform.position;
    }
    
    void FixedUpdate () {
		Vector3 posicionDeseada = jugador.position + offset;
		Vector3 posicionDeseadaMejorada = Vector3.Lerp(transform.position, posicionDeseada, velocidadCamara);
		transform.position = posicionDeseadaMejorada;
    }

    #endregion
}
