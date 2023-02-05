using UnityEngine;

public class PlankControl : MonoBehaviour
{
    private Rigidbody _rigibody;
    private Transform _transform;
    
    [Header("Plank Settings")]
    [SerializeField]private float speed = 100.0f;
    [SerializeField]private float rotationSpeed = 100f;

    private void Awake()
    {
        _transform = transform;
    }
    // Start is called before the first frame update
    private void Start()
    {
        _rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        _transform.Rotate(rotation, 0 , translation);
    }
}
