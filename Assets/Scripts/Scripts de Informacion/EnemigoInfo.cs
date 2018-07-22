using UnityEngine;

[CreateAssetMenu(fileName = "NuevoEnemigo", menuName = "Enemigo/Basico")]
public class EnemigoInfo : ScriptableObject {

	/*
	Contiene información de los enemigos
	*/

	public enum habilidades
	{
		NINGUNA, INVISIBILIDAD
	}

	#region Variables
	[Header("Stats")]
	[Range(2f, 20f)]
	public int vida;
	public habilidades habilidad;
	[Range(0.7f, 3f)]
	[Tooltip("Cooldown al disparar")]
	public float cooldown;
	public float cooldownHabilidad;
	public float duracionHabilidad;
	[Range(0.1f, 5f)]
	public int danno;

	[Space]

	[Header("Misc")]
	public string nombreDeNave;
	[TextArea]
	public string descripcion;
	#endregion
}
