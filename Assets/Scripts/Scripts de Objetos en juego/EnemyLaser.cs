using UnityEngine;

public class EnemyLaser : MonoBehaviour {

	#region Variables
	[SerializeField]
	private float __velocidad;
	private float __tiempo = 5f;
	#endregion

	#region Unity Methods

    void Update () {
		vidaDeLaser();//Si se acaba el tiempo del variable __tiempo, despawnear el laser
		movimientoLaser();
    }

	void OnTriggerEnter(Collider obj)
	{
		if (obj.tag == "planet")
		{
			Destroy(gameObject);
		}
        if (obj.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    #endregion

	void movimientoLaser()
	{
		Vector3 nuevoVector3 = new Vector3(0, (-1)*__velocidad * Time.deltaTime, 0);
		transform.Translate(nuevoVector3);
	}

	void vidaDeLaser()
	{
		__tiempo -= Time.deltaTime;
		if (__tiempo < 0)
		{
			Destroy(gameObject);

		}
	}
}
