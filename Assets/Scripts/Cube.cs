using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    public float speed = 5.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
