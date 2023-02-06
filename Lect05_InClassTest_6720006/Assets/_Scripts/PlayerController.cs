using UnityEngine;

namespace _Scripts
{
    public class PlayerController : MonoBehaviour
    {
        Transform _transform;
        [SerializeField]
        float rotateSpeed = 100f;
        void Awake()
        {
            _transform = transform;
        }

        // Update is called once per frame
        void Update()
        {
            // Rotating the player using "W" and "D" keys.
            RotatePlayer ();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        void RotatePlayer()
        {
            float zMove = Input.GetAxis("Horizontal") * (rotateSpeed * Time.deltaTime);
            _transform.Rotate(0f,0f,zMove);
        }
    }
}
