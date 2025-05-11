using UnityEngine;

public class MyRobot : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private AudioSource audioSource;

    public float speed = 5.0f;

    private void OnFootstep()
    {
        Debug.Log("OnFootstep");
        audioSource.Play();
    }

    private void OnAttack()
    {
        Debug.Log("OnAttack");
        isAttack = false;
    }

    void Start()
    {
        animator.Play("IDLE");
    }

    bool isAttack = false;

    void Update()
    {
        bool isMoving = false;

        if (Input.GetKey(KeyCode.W) && isAttack == false)
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S) && isAttack == false)
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A) && isAttack == false)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.D) && isAttack == false)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            isMoving = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isAttack = true;
            animator.Play("ATTACK");
        }

        if (isMoving)
        {
            animator.Play("RUN");
        }
        if (isMoving == false && isAttack == false)
        {
            animator.Play("IDLE");
        }

    }
}
