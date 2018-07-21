using UnityEngine;

[CreateAssetMenu(fileName = "NuevaNave", menuName ="Nave")]
public class PlayerInfo : ScriptableObject {
	/*
		Contiene información sobre las naves disponibles
		al jugador.
	*/


	#region Variables

	//TODO:
	//Cambiar este enum y sus valores para que tengan
	//las habilidades finales del juego
	public enum habilidades
	{
		VELOCIDAD, VIDA, REGENERACION, ESCUDO, VELOCIDADDEATAQUE, EXPLOSIVOS
	};

	[Header("Stats")]
	[Range(2f, 6f)]
	public int vida;
	public habilidades habilidad;
	[Range(0.7f, 3f)]
	[Tooltip("Cooldown al disparar")]
	public float cooldown;
	public float cooldownHabilidad;
	public float duracionHabilidad;
	[Range(1f,6f)]
	public int danno;

	[Space]

	[Header("Misc")]
	public string nombreDeNave;
	public string descripcion;


	#endregion

}
