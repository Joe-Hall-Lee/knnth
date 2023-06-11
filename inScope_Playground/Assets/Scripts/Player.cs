using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    #region COMPONENTS

    [SerializeField]
    private CharacterController characterController;

    private PlayerActions actions;
   
    [SerializeField]
    private AnyStateAnimator anyStateAnimator;

    #endregion

    #region INPUT

    private Vector2 movementInput;

    private float horizontalMouseInput;

    #endregion

    #region ANIMATION

    [SerializeField]
    private float animationSmoothTime;

    private Vector2 animationVector;
    #endregion

    #region VALUES

    [SerializeField]
    private float walkSpeed;

    [SerializeField]
    private float runSpeed;

    private float currentSpeed;

    [SerializeField]
    private float rotationSpeed;

    private bool isRunning;

    private bool canShoot = true;

    [SerializeField]
    private float shootDelay;

    [SerializeField]
    private Vector3 playerVelocity;

    private float gravityValue = -9.81f;

    [SerializeField]
    private float jumpHeight;

    private bool isGrounded = false;

    private float lastY;

    private bool dead = false;

    #endregion

    private void Awake()
    {
        currentSpeed = walkSpeed;
        actions = new PlayerActions();
        actions.Controls.Move.performed += cxt => movementInput = cxt.ReadValue<Vector2>();
        actions.Controls.MouseMovement.performed += cxt => horizontalMouseInput = cxt.ReadValue<float>();
        actions.Controls.Run.performed += cxt => Run();
        actions.Controls.Jump.performed += cxt => Jump();
        actions.Controls.Wave.performed += cxt => Wave();
        actions.Controls.Aim.performed += cxt => Aim();
    }


    // Start is called before the first frame update
    private void Start()
    {
        AnyStateAnimation idle = new AnyStateAnimation("Idle", false, "Jump", "Fall", "Die");
        AnyStateAnimation walk = new AnyStateAnimation("Walk", false, "Jump", "Fall", "Die");
        AnyStateAnimation run = new AnyStateAnimation("Run", false, "Jump", "Fall", "Die");
        AnyStateAnimation jump = new AnyStateAnimation("Jump", false, "Fall", "Die");
        AnyStateAnimation fall = new AnyStateAnimation("Fall", false, "Die");
        AnyStateAnimation wave = new AnyStateAnimation("Wave", true, "Die");
        AnyStateAnimation aim = new AnyStateAnimation("Aim", true, "Die");
        AnyStateAnimation shoot = new AnyStateAnimation("Shoot", true, "Die");
        AnyStateAnimation die = new AnyStateAnimation("Die", false);

        anyStateAnimator.AddAnimations(idle, walk, run, jump, wave, aim, shoot, fall, die);
    }


    // Update is called once per frame
    private void Update()
    {      
        Gravity();
        if (!dead)
        {
            Movement();
            Rotate();
            Shoot();
            AicControl();
        }
    }

    
    public void Movement()
    {
        Vector3 movement = transform.right * movementInput.x + transform.forward * movementInput.y;

        animationVector = Vector2.MoveTowards(animationVector, movement, animationSmoothTime * Time.deltaTime);

        characterController.Move(movement * currentSpeed * Time.deltaTime);

        if (isRunning)
        {
            anyStateAnimator.TryPlayAnimation("Run");
        }
        else if (movementInput.y != 0 || movementInput.x != 0)
        {
            anyStateAnimator.TryPlayAnimation("Walk");
        }
        if (characterController.velocity == Vector3.zero && animationVector == Vector2.zero)
        {
            anyStateAnimator.TryPlayAnimation("Idle");
        }

        anyStateAnimator.Animator.SetFloat("Vertical", animationVector.y);
        anyStateAnimator.Animator.SetFloat("Horizontal", animationVector.x);
    }


    private void Rotate()
    {
        if (!Mouse.current.rightButton.isPressed)
        {
            float mouseX = horizontalMouseInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    }


    private void Run()
    {
        isRunning = !isRunning;

        if (isRunning)
        {
            // We need to run
            currentSpeed = runSpeed;
        }
        else
        {
            // We need to stop running
            currentSpeed = walkSpeed;
        }
    }


    private void Gravity()
    {
        playerVelocity.y += gravityValue * Time.deltaTime;

        characterController.Move(playerVelocity * Time.deltaTime);

        if (characterController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
            isGrounded = true;
        }
    }


    private void AicControl()
    {
        float distancePerSecondSinceLastFram = (transform.position.y - lastY) * Time.deltaTime;
        lastY = transform.position.y;

        if (distancePerSecondSinceLastFram < 0 && !isGrounded)
        {
            // we are falling
            anyStateAnimator.TryPlayAnimation("Fall");
        }
        else
        {
            // we are not falling
            anyStateAnimator.OnAnimationDone("Fall");
        }
        if (anyStateAnimator.IsAnimationActive("Jump") && isGrounded)
        {
            anyStateAnimator.OnAnimationDone("Jump");
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            isGrounded = false;
            anyStateAnimator.TryPlayAnimation("Jump");
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

    }


    private void Wave()
    {
        anyStateAnimator.TryPlayAnimation("Wave");
    }


    private void Aim()
    {
        if (!anyStateAnimator.IsAnimationActive("Aim"))
        {
            anyStateAnimator.TryPlayAnimation("Aim");
        }
        else
        {
            anyStateAnimator.OnAnimationDone("Aim"); 
        }

    }


    private void Shoot()
    {
        if (canShoot && Mouse.current.leftButton.IsPressed())
        {    
            if (anyStateAnimator.IsAnimationActive("Aim"))
            {
                canShoot = false;
                anyStateAnimator.TryPlayAnimation("Shoot");
                StartCoroutine(ShootCooldown());
            }
        }
    }


    private IEnumerator ShootCooldown()
    {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }


    private void OnEnable()
    {
        actions.Enable();
    }


    private void OnDisable()
    {
        actions.Disable();
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player hit!");
    }


    public void Die()
    {
        if (!dead)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            anyStateAnimator.TryPlayAnimation("Die");
            dead = true;
        }
    }
}