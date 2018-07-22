using UnityEngine;
//Mantiene informacion de la partida y general
[DisallowMultipleComponent]
public class Informacion : MonoBehaviour
{
	static public int J1;//Decide cual indice es el jugador para escojer la nave
	static public GameObject[] navesObject;//Contiene las naves disponibles
	public GameObject[] navesObjectaux;

	//TODO:
	//Cambiar este enum y sus valores para que tengan
	//los nombres de las naves
	public enum naves
	{
		MARKI, Gears
	}


	void Start()
	{
		Informacion.navesObject = navesObjectaux;
	}

	
}