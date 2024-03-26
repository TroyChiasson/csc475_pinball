using UnityEngine;


public enum FlipperType
{
    LEFT,
    RIGHT,
}
public class Flipper : MonoBehaviour
{
    public FlipperType type;
    private Rigidbody rb;
    public float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var input = GameManager.Instance.input;
        if (type == FlipperType.LEFT && input.Default.FlipperL.WasPressedThisFrame())
        {
            Flip();
        }
        else if (type == FlipperType.RIGHT && input.Default.FlipperR.WasPressedThisFrame())
        {
            Flip();
        }
    }
    public void Flip()
    {
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
