using Unity.Cinemachine;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    public float speed = 1.0f;

    public CinemachineCamera cam1;
    public CinemachineCamera cam2;
    private CinemachineBrain brain;

    void Start()
    {
        brain = GetComponent<CinemachineBrain>();
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x, 5, -10);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            cam1.Priority = 10;
            cam2.Priority = 0;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            cam2.Priority = 10;
            cam1.Priority = 0;
        }
    }

}
