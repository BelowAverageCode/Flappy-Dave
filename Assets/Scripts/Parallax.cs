using UnityEngine;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
