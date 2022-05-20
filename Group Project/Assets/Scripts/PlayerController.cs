using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed = 20;
	public float turnSpeed = 50;
	public int maxHealth = 100;
	public int currentHealth;


	
	public Healthbar Healthbar;
	
    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		Healthbar.SetMaxHealth(maxHealth);

    }
    

    // Update is called once per frame
    void Update()
    {
        //get player input
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");
        float pitchInput = Input.GetAxis("Pitch");

        //Move the vehicle forward
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Rotate(Vector3.right, turnSpeed * pitchInput * Time.deltaTime);
        Vector3 forwardDirection = transform.rotation * Vector3.forward;
		GetComponent<Rigidbody>().velocity = forwardDirection * speed * forwardInput;
        //transform.Translate(Vector3.forward * speed * forwardInput);
		
		//if(Input.GetKeyDown(KeyCode.Space))
		//{
			//TakeDamage(20);
		//}

		if (currentHealth == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag=="Enemy")
        {
            TakeDamage(20);
        }
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		Healthbar.SetHealth(currentHealth);
	}

}
