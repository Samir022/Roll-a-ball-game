using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public GameObject bodyPrefab; // Reference to the BodyPrefab GameObject

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Spawn a new instance of the bodyPrefab at the position of the Tail GameObject
            GameObject newBody = Instantiate(bodyPrefab, GameObject.Find("Tail").transform.position, Quaternion.identity);

            // Set the parent of the new instance to the Tail GameObject
            newBody.transform.SetParent(GameObject.Find("Tail").transform);

            // Move the Tail GameObject to the position of the Player GameObject
            GameObject.Find("Tail").transform.position = other.gameObject.transform.position;

            // Destroy the pickup object
            Destroy(gameObject);
        }
    }
}

