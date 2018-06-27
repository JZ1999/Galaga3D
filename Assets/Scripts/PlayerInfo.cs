using UnityEngine;

[CreateAssetMenu(fileName = "NewShip", menuName ="Ship")]
public class PlayerInfo : ScriptableObject {

	#region Variables
	public enum abilities
	{
		SPEED, HEALTH, REGEN, SHIELD
	};

	public int health;
	public abilities ability;
	public int points;
	public string shipName;
	public string description;

	#endregion

}
