using UnityEngine;
using System.Collections;

public class MainCameraMovement : MonoBehaviour 
{	
	public Vector3 m_resultingPosition;

	void Start () 
	{

	}
	

	void Update () 
	{
		Vector2 positionPool = Vector2.zero;
		foreach (Transform child in transform)
		{
			// do whatever you want with child transform object here
			positionPool.x += child.position.x;
			positionPool.y += child.position.y;
		}

		positionPool.x /= transform.childCount;
		positionPool.y /= transform.childCount;

		m_resultingPosition = new Vector3 (positionPool.x, positionPool.y, -10f);
		Camera.main.transform.position = m_resultingPosition;
	}
}
