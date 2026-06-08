using UnityEngine;

public class ModelController : MonoBehaviour
{
    [Header("Referências do Modelo")]

    [Tooltip("Transform do modelo 3D que será manipulado")]
    [SerializeField] private Transform modelTransform;

    [Tooltip("Renderer utilizado para controlar a visibilidade do modelo")]
    [SerializeField] private MeshRenderer modelRenderer;

    public void SetScale(float value)
    {

    }

    public void SetVisibility(bool visible)
    {

    }

    public void ResetModel()
    {

    }
}
