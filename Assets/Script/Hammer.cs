using UnityEngine;

public class Hammer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}