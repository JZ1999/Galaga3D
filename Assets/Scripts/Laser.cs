using UnityEngine;

public class Laser : MonoBehaviour {

	#region Variables
	public float speed;
    #endregion

    #region Unity Methods

    void Start () {

    }
    
    void Update () {
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
