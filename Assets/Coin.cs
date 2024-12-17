using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f; // Adjust this value to change the rotation speed

    private void Update()
    {
        RotateCoin();
    }

    private void RotateCoin()
    {
        // Rotate the coin around its up axis (y-axis)
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime), Space.Self);
    }
}