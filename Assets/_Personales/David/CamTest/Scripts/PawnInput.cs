using UnityEngine;
using System.Collections;

public class PawnInput : MonoBehaviour 
{

	private PawnMovement m_movement;
	
	void Awake () 
	{
		m_movement = GetComponent<PawnMovement>();	
	}
	
	
	void Update () 
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		Vector2 inputAxis = new Vector2(inputX, inputY).normalized;
		
		m_movement.Walk(inputAxis);
		
		if (Input.GetButtonDown("Fire1"))
		{
			m_movement.ToggleCamera();
		}
		
		// Mientras este el boton pulsado, defendemos
		if (Input.GetButtonDown("Fire2"))
		{
			//m_movement.Defend();
		}
		
		// Cuando se suelta el boton, dejamos de defender
		if (Input.GetButtonUp("Fire3"))
		{
			//m_movement.StopDefend();
		}
		
		// Cambiar de arma
		if (Input.GetButtonDown("Jump"))
		{
			//m_movement.ChangeWeapon();
		}		
		
	}
}
