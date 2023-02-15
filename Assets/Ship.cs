using UnityEngine;

public class Ship : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 5f;
	[SerializeField] private float _rotateSpeed = 1f;
	

	private void Update()
	{
		var x = Input.GetAxisRaw("Vertical");
		var y = Input.GetAxisRaw("Horizontal");

		var forward = -transform.up;

		transform.position += forward * (x * _moveSpeed * Time.deltaTime);
		transform.Rotate(Vector3.forward, y * Time.deltaTime);
	}
}
