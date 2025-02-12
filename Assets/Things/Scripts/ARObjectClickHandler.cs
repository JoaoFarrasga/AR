using UnityEngine;

public class ARObjectClickHandler : MonoBehaviour
{
    public GameObject objectToSpawn;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform == transform)
                {
                    Instantiate(objectToSpawn,
                                hit.transform.position + new Vector3(0, 0.2f, 0),
                                Quaternion.identity);
                }
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);

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
