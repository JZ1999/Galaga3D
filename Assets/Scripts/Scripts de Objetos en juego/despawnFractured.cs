using UnityEngine;

public class despawnFractured : MonoBehaviour {

    #region Variables
	[SerializeField]
	private float despawnTime;
	[SerializeField]
	private AudioSource crackling;
	#endregion

	#region Unity Methods

	void Start () {
		crackling.Play();
    }
    
    void Update () {
		despawnTime -= Time.deltaTime;
        if(despawnTime < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
