using UnityEngine;

public class Set : MonoBehaviour
{
    public GameObject obj;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            obj.SetActive(true);
        }
    }
}
