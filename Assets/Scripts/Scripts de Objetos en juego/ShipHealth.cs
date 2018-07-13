using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour {

	#region Variables
	public PlayerInfo ship;
	[HideInInspector]
	public Text life;
	private int health;
	private float[] colors;
	private float percentRed;//Percent needed to subtract from text red everytime it receives dmg
    #endregion

    #region Unity Methods

    void Start () {
		life = FindObjectOfType<Text>();
		health = ship.health;
		life.text = ship.health.ToString();
		colors = new float[] { life.color.r, life.color.g, life.color.b };
		percentRed = colors[0] / 20;
	}
    
    void Update () {
        
    }

	void OnTriggerEnter(Collider obj)
	{
		if (obj.tag != "laser")
		{
			Debug.Log("Enter");
		}
		if (obj.tag == "planet")
		{
			
			health -= 1;
			life.text = health.ToString();
			
			life.color = new Color(colors[0]-=percentRed, colors[1], colors[2]);
		}

		if(health == 0)
		{
			Destroy(gameObject);
		}
	}

    #endregion
}
