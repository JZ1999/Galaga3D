using UnityEngine;

public class Fracture : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject fracturado;//La version del objeto fraturada
	[SerializeField]
	private int health;
	[SerializeField]
	private AudioSource laserCrash;//Se debe sonar el sonido del choque
									//con este script del planet en vez
									//del laser debido a que el laser se
									//destruye y no le da tiempo al AudioSource
									//de sonar
	#endregion

	#region Unity Methods


	void OnTriggerEnter(Collider obj)
	{
		if(obj.tag == "laser")
		{
			colisionConLaser();
		}
        if (obj.tag == "enemylaser")
        {
            colisionConLaser();
        }
    }

	#endregion
	void fracturarPlaneta()
	{
		Instantiate(fracturado, transform.position, transform.rotation);
		Destroy(gameObject);
	}

	void colisionConLaser()
	{
		laserCrash.Play();
		health--;
		if (health <= 0)
		{
			fracturarPlaneta();
		}
	}
}
