
using UnityEngine;
namespace NaveGame.Misc
{
public class Spinner : MonoBehaviour
{
    public Vector3 eulersPerSecond;

    void Update()
    {
        transform.Rotate(eulersPerSecond * Time.deltaTime);
    }
}
}