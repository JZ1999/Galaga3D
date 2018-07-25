using UnityEngine;
[DisallowMultipleComponent]
public class Movement : MonoBehaviour {

	#region Variables
	[SerializeField]
	private Rigidbody rb;
	[SerializeField]
	private float _velocidad;
	[SerializeField]
	private float _rotacion;
	[SerializeField]
	private float _bordeHorizontal;

	[SerializeField]
	private KeyCode izquierda;
	[SerializeField]
	private KeyCode derecha;
	[SerializeField]
	private KeyCode arriba;
	[SerializeField]
	private KeyCode abajo;
	#endregion

	#region Unity Methods

	void FixedUpdate () {
		int _movimiento_horizontal = aplicarRotacion(conseguirMovimientoHorizontal());
        int _movimiento_vertical = conseguirMovimientoVertical();

        if (seEstaMoviendo(_movimiento_horizontal, _movimiento_vertical))
		{
			aplicarMovimiento(_movimiento_horizontal, _movimiento_vertical);
		}
		if (pasoElLimite())
		{
			detenerYmoverALadoContrario();
		}
    }

    #endregion

	void aplicarMovimiento(int _movimientoH, int _movimientoV)
	{
        float new_x = _velocidad * Time.deltaTime * _movimientoH*5;
        float new_y = _velocidad * Time.deltaTime * _movimientoV*5;
        rb.AddForce(new Vector3(new_x, new_y, 0));
    }

	bool seEstaMoviendo(int _movimientoH, int _movimientoV)
	{
		return (_movimientoH != 0 || _movimientoV != 0);
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
		return transform.position.x > _bordeHorizontal ? Vector3.left : Vector3.right;
	}

	bool pasoElLimite()
	{
		return transform.position.x > _bordeHorizontal || transform.position.x < -_bordeHorizontal;
	}

	int conseguirMovimientoHorizontal()
	{
		if (Input.GetKey(izquierda))
			return -1;
		else if (Input.GetKey(derecha))
			return 1;
		return 0;
	}

    int conseguirMovimientoVertical()
    {
        if (Input.GetKey(abajo))
            return -1;
        else if (Input.GetKey(arriba))
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

