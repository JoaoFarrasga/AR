using UnityEngine;

public class DestroyAfter5Seconds : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);  
    }
}
