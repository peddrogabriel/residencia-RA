using UnityEngine;

public class ModelController : MonoBehaviour
{
    [Header("Referências do Modelo")]

    [Tooltip("Transform do modelo 3D que será manipulado")]
    [SerializeField] private Transform modelTransform;

    private Vector3 initialScale;

    void Start()
    {
        initialScale = modelTransform.localScale;

    }

    public void SetScale(float value)
    {
        value = Mathf.Clamp(value, 0.5f, 5.0f);

        modelTransform.localScale = new Vector3(value, value, value);
    }

    public void SetVisibility(bool visible)
    {
        MeshRenderer[] renderers = modelTransform.GetComponentsInChildren<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.enabled = visible;
        }
    }

    public void ResetModel()
    {
        modelTransform.localScale = initialScale;

        SetVisibility(true);
    }
}
