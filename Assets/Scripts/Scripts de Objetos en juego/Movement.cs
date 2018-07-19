using UnityEngine;

public class Movement : MonoBehaviour {

	#region Variables
	[SerializeField]
	private Rigidbody rb;
	[SerializeField]
	private float _velocidad;
	[SerializeField]
	private float _rotacion;
    #endregion

    #region Unity Methods
    
    void Update () {
		int _movement = aplicarRotacion(conseguirMovimiento());
		if (seEstaMoviendo(_movement))
		{
			aplicarMovimiento(_movement);
		}
		if (pasoElLimite())
		{
			detenerYmoverALadoContrario();
		}
    }

    #endregion

	void aplicarMovimiento(int _movement)
	{
		float new_x = _velocidad * Time.deltaTime * _movement;
		rb.AddForce(new Vector3(new_x, 0, 0));
	}

	bool seEstaMoviendo(int _movement)
	{
		return _movement != 0;
	}

	void detenerYmoverALadoContrario()
	{
		Vector3 direccionAMover = cualBordeToco();
		rb.AddForce(direccionAMover);
		rb.velocity = Vector3.zero;
	}

	Vector3 cualBordeToco()
	{
		//Devuelve un vector3 dependiendo de cual border tocó
		//para poder moverlo al lado contrario
		return transform.position.x > 4.5 ? Vector3.left : Vector3.right;
	}

	bool pasoElLimite()
	{
		return transform.position.x > 4.5 || transform.position.x < -4.5;
	}

	int conseguirMovimiento()
	{
		if (Input.GetKey(KeyCode.A))
			return -1;
		else if (Input.GetKey(KeyCode.D))
			return 1;
		return 0;
	}

	int aplicarRotacion(int _dir)
	{
		float _z = transform.rotation.z;
		//Un limite a la cantidad de rotacion que uno puede tener
		bool _puedeRotar = _z > -0.13 && _z < 0.13;
		bool _puedeRotarIzquierda = _z > -0.13;
		bool _puedeRotarDerecha = _z < 0.13;

		if (_puedeRotar)
			transform.Rotate(new Vector3(0, 0, _rotacion * -_dir));
		else if ( !_puedeRotarIzquierda && _dir == 1 )
			transform.Rotate(new Vector3(0,0, _rotacion * -_dir));
		else if (!_puedeRotarDerecha && _dir == -1)
			transform.Rotate(new Vector3(0, 0, _rotacion * -_dir));
		return _dir;
	}

}

