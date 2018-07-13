using UnityEngine;

[CreateAssetMenu(fileName = "NewShip", menuName ="Ship")]
public class PlayerInfo : ScriptableObject {
	/*
		Contiene información sobre las naves disponibles
		al jugador.
	*/


	#region Variables


	public enum abilities
	{
		SPEED, HEALTH, REGEN, SHIELD, ATTACKSPEED, EXPLOSIVES
	};

	[Header("Stats")]
	[Range(2f, 6f)]
	public int health;
	public abilities ability;
	[Range(0.7f, 3f)]
	[Tooltip("Cooldown al disparar")]
	public float cooldown;
	public float abilityCooldown;
	public float abilityDuration;
	[Range(1f,6f)]
	public int damage;

	[Space]

	[Header("Misc")]
	public string shipName;
	public string description;


	#endregion

}
