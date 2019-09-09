using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	
	// Represents the player.

	public float force;
	private Rigidbody rb;
	
	private void Awake ()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (!(transform.position.y < -15) || LevelManager.Instance.isComplete) return;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Score.ResetPenalty();
	}

	private void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddForce(new Vector3(0,0,force) * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			rb.AddForce(new Vector3(-force,0) * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			rb.AddForce(new Vector3(0,0, -force) * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			rb.AddForce(new Vector3(force,0) * Time.deltaTime);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.layer == 10) return;
		Score.AddPenalty();
	}
}
