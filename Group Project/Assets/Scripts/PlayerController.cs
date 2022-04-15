using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private float speed = 20;
	private float turnSpeed = 50;
	private float horizontalInput;
	private float forwardInput;
	public int maxHealth = 100;
	public int currentHealth;
	public int maxStamina = 100;
	public int currentStamina;
	
	public Healthbar Healthbar;
	public Staminabar Staminabar;
	
    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		Healthbar.SetMaxHealth(maxHealth);
		currentStamina = maxStamina;
		Staminabar.SetMaxStamina(maxStamina);
    }
    

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

		//Move the vehicle forward
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
		Vector3 forwardDirection = transform.rotation * Vector3.forward;
		GetComponent<Rigidbody>().velocity = forwardDirection * speed * forwardInput;
        //transform.Translate(Vector3.forward * speed * forwardInput);
		
		//if(Input.GetKeyDown(KeyCode.Space))
		//{
			//TakeDamage(20);
		//}
		
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			TakeStaminaDamage(20);
		}

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

	void TakeStaminaDamage(int staminaDamage)
	{
		currentStamina -= staminaDamage;
		Staminabar.SetStamina(currentStamina);
	}

	

}
