using UnityEngine;
[DisallowMultipleComponent]
public class Fracture : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject fracturado;//La version del objeto fraturada
	[SerializeField]
	[Tooltip("La vida del planeta/obstaculo")]
	private int _vida;
	[SerializeField]
	private AudioSource laserCrash;//Se debe sonar el sonido del choque
								   //con este script del planet en vez
								   //del laser debido a que el laser se
								   //destruye y no le da tiempo al AudioSource
								   //de sonar

	[SerializeField]
	private string _tagDelLaser;
	[SerializeField]
	private string _tagDelLaserEnemigo;
	#endregion

	#region Unity Methods


	void OnTriggerEnter(Collider obj)
	{
		if(obj.tag == _tagDelLaser || obj.tag == _tagDelLaserEnemigo)
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
		_vida--;
		if (_vida <= 0)
		{
			fracturarPlaneta();
		}
	}
}
