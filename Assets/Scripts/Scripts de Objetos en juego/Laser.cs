using UnityEngine;

public class Laser : MonoBehaviour {

	#region Variables
	public float speed;
	private float Timer = 5f;
	#endregion

	#region Unity Methods

	void Start () {

    }
    
    void Update () {
		Timer -= Time.deltaTime;
		if (Timer < 0)
		{
			Destroy(gameObject);

		}

		transform.Translate(new Vector3(0,speed * Time.deltaTime, 0));
    }

	void OnTriggerEnter(Collider obj)
	{
		
		if (obj.tag == "planet")
		{
			Destroy(gameObject);
		}
	}

    #endregion
}
