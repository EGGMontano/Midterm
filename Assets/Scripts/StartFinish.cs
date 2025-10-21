using UnityEngine;

public class StartFinish : MonoBehaviour
{
    private void Update()
    {
        void OnTriggerEnter(Collider col)
    {
            if (col.gameObject.tag == "wall")
            {
                Destroy(transform);
                Debug.Log("FINALLY!");
            }
        }
    }
}
