using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    private PlayerActions actions;

    private float mouseX;

    private Vector3 offset;

    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private float returnSpeed;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private Transform defaultTransform;

    [SerializeField]
    [Range(0.01f, 1.0f)]
    private float smoothFactor;

    private bool cameraRotated = false;


    private void Awake()
    {
        actions = new PlayerActions();
        actions.Controls.MouseMovement.performed += cxt => mouseX = cxt.ReadValue<float>();
        offset = transform.position - target.transform.position;
    }


    private void LateUpdate()
    {
        if (Mouse.current.rightButton.isPressed)
        {
            cameraRotated = true;
        }
        if (cameraRotated && !Mouse.current.rightButton.isPressed)
        {
            Vector3 localPos = transform.InverseTransformPoint(defaultTransform.position);

            float xDir = localPos.x < 0.0f ? 1 : -1;

            Rotate(xDir, returnSpeed);

            if (Vector3.Distance(transform.position, defaultTransform.position) <= 0.1f && cameraRotated)
            {
                cameraRotated = false;
                transform.position = defaultTransform.position;
                offset = transform.position - target.transform.position;
            }
        }
        else
        {
            Rotate(mouseX, rotationSpeed);
        }

        transform.LookAt(target);
    }

    private void Rotate(float rotationAmount, float speed)
    {
        Quaternion camTurnAngle = Quaternion.AngleAxis(rotationAmount * speed * Time.deltaTime, Vector3.up);

        offset = camTurnAngle * offset;

        Vector3 newPos = target.position + offset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }

    private void OnEnable()
    {
        actions.Enable();
    }


    private void OnDisable()
    {
        actions.Disable();
    }
}