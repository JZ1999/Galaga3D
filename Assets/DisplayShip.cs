using UnityEngine;

public class DisplayShip : MonoBehaviour {

	#region Variables
	public PlayerInfo ship;
    #endregion

    #region Unity Methods

    void Start () {
        
    }
    
    void Update () {
        
    }

	void OnTriggerEnter(Collider obj)
	{
		if(obj.tag == "planet")
		{
			Debug.Log(ship.health);
			ship.health -= 1;
		}

		if(ship.health == 0)
		{
			Destroy(gameObject);
		}
	}

    #endregion
}
