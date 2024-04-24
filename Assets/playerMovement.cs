using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    SoundManager soundManagerScript;
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;

    float speedAmount = 100f;
    float jumpAmount = 150f;
    // Start is called before the first frame update
    void Start()
    {
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        rgb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {

            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            soundManagerScript.Jump();
            animator.SetBool("isJumping",true);
            
        }
        if(animator.GetBool("isJumping") && Mathf.Approximately(rgb.velocity.y,0))
        {
            animator.SetBool("isJumping", false);
            //soundManagerScript.Jump();

        }

        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }
        else if(Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

    }
}
