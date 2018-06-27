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
		Debug.Log("Laser1");
		if (obj.tag == "planet")
		{
			Debug.Log("Laser");
			Destroy(gameObject);
		}
	}

    #endregion
}
