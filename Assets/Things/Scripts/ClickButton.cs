using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public GameObject gameObject;

    public void Spawn()
    {
        Instantiate(gameObject);
    }
}
