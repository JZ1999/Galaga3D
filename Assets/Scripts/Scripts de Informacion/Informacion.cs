using UnityEngine;
//Mantiene informacion de la partida y general
public class Informacion : MonoBehaviour
{
	static public int J1;
	static public GameObject[] navesObject;
	public GameObject[] navesObjectaux;

	public enum naves
	{
		MARKI, Gears
	}

	void Start()
	{
		Informacion.navesObject = navesObjectaux;
	}

	
}