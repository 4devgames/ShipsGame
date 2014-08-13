using UnityEngine;
using System.Collections;

public class PawnMovement : MonoBehaviour 
{
	public Vector2 m_speed = new Vector2 ( 16f, 16f );

	private Camera m_pawnCamera;


	void Awake () 
	{
		m_pawnCamera = GetComponentInChildren<Camera>();
	}
	

	void LateUpdate () 
	{
		ConstraintPosition();
	}


	public void Walk ( Vector2 p_input )
	{
		Vector3 inputV3 = new Vector3 (
			p_input.x * m_speed.x * Time.deltaTime,
			p_input.y * m_speed.y * Time.deltaTime,
			0f);
		transform.Translate(inputV3);
	}


	public void ToggleCamera ()
	{
		m_pawnCamera.enabled = !m_pawnCamera.enabled;
	}


	void ConstraintPosition ()
	{
		Vector3 viewportPos = Camera.main.WorldToViewportPoint(transform.position);
		viewportPos.x = Mathf.Clamp01(viewportPos.x);
		viewportPos.y = Mathf.Clamp01(viewportPos.y);
		transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
	}
}
