using UnityEngine;

public class ARObjectClickHandler : MonoBehaviour
{
    public GameObject objectToSpawn;

    public Camera arCamera;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = arCamera.ScreenPointToRay(touch.position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    Instantiate(objectToSpawn, 
                                hit.transform.position + new Vector3(0, 0.2f, 0),
                                Quaternion.identity);
                }
            }
        }
    }
}
