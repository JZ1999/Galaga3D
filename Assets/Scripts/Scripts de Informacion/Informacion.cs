﻿using UnityEngine;
//Mantiene informacion de la partida y general
[DisallowMultipleComponent]
public class Informacion : MonoBehaviour
{
	static public int J1;
	static public GameObject[] navesObject;
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