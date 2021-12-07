using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;


    public CharacterController charController;
    private Vector2 move = Vector2.zero;
    

    [Header("Movement")]
    public float speed = 40f;

    [Header("Shooting")]
    public GameObject shoot;
    public Transform shotSpawn;

    AudioSource audioSource;

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameManager.instance.gameOver)
        {


            move = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), 0);

            move = transform.TransformDirection(move);
            charController.Move(move * Time.deltaTime * speed);

            if (CrossPlatformInputManager.GetButtonDown("Fire1"))
            {
                Instantiate(shoot, shotSpawn.position, shotSpawn.rotation);
                audioSource.Play();
            }

        }

    }
}
