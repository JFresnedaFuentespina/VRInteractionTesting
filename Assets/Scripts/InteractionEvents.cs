using UnityEngine;

public class InteractionEvents : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public MeshRenderer meshRenderer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCubeHover()
    {
        meshRenderer.material.color = new Color(1, 1, 1, 1);
    }

    public void OnCubeUnhover()
    {
        meshRenderer.material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);

    }
    public void OnCubeSelected()
    {
        meshRenderer.material.color = new Color(1, 0, 0, 1);
    }

    public void OnCubeUnSelected()
    {
        meshRenderer.material.color = new Color(1, 1, 1, 1);

    }
}
