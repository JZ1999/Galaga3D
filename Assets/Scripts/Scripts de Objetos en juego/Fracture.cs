using UnityEngine;

public class Fracture : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject fractured;
	[SerializeField]
	private int health;
	[SerializeField]
	private AudioSource laserCrash;
	#endregion

	#region Unity Methods


	void OnTriggerEnter(Collider obj)
	{
		
		if(obj.tag == "laser")
		{
			laserCrash.Play();
			health--;
			if(health <= 0)
			{
				fracturePlanet();
			}
		}
	}

	void fracturePlanet()
	{
		Instantiate(fractured, transform.position, transform.rotation);
		Destroy(gameObject);
	}

	#endregion
}
